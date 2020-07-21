using System;
using System.Collections.Generic;
using System.IO;

using UnityEngine;
using UnityEditor;

namespace exercise0000000
{
    public class ExercisesMacroSelectorWindow : EditorWindow
    {
        [MenuItem("Exercises/MacroSelector")]
        public static void ShowExercisesMacroSelectorWindow()
        {
            ExercisesMacroSelectorWindow window = GetWindow<ExercisesMacroSelectorWindow>();
        }

        private BuildTarget _active_build_target;
        private BuildTargetGroup _selected_build_target_group;

        private List<string> _macro_list = new List<string>();
        private bool[] _macro_state_arr;

        private List<string> _other_symbols = new List<string>();

        public void Awake()
        {
            _active_build_target = EditorUserBuildSettings.activeBuildTarget;
            _selected_build_target_group = EditorUserBuildSettings.selectedBuildTargetGroup;

            string exercise_path = Path.Combine(new string[] { Application.dataPath, "Exercises" });
            string[] exercise_sub_paths = Directory.GetDirectories(exercise_path, "*", SearchOption.TopDirectoryOnly);

            for (int i = 1; i < exercise_sub_paths.Length; ++i)
            {
                _macro_list.Add(Path.GetFileName(exercise_sub_paths[i]));
            }

            _macro_state_arr = new bool[_macro_list.Count];

            string symbols_str = PlayerSettings.GetScriptingDefineSymbolsForGroup(_selected_build_target_group);
            string[] symbols_arr = symbols_str.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> symbols_list = new List<string>(symbols_arr);

            for (int i = 0; i < _macro_list.Count; ++i)
            {
                _macro_state_arr[i] = -1 != symbols_list.IndexOf(_macro_list[i]);
            }

            foreach (string symbol in symbols_list)
            {
                if (-1 == _macro_list.IndexOf(symbol))
                {
                    _other_symbols.Add(symbol);
                }
            }
        }

        public void OnGUI()
        {
            {
                GUILayout.BeginHorizontal();
                GUILayout.Label("Active Build Target: " + _active_build_target.ToString());
                GUILayout.Label("Selected Build Target Group: " + _selected_build_target_group.ToString());
                GUILayout.Label("Editor Is Compiling: " + EditorApplication.isCompiling.ToString());
                GUILayout.EndHorizontal();
            }


            GUILayout.Space(8f);

            {
                GUILayout.BeginHorizontal();

                for (int i = 0; i < _macro_list.Count; ++i)
                {
                    _macro_state_arr[i] = GUILayout.Toggle(_macro_state_arr[i], _macro_list[i], GUILayout.MaxWidth(128));

                    GUILayout.Space(4f);

                    if (0 == ((i + 1) % 4))
                    {
                        GUILayout.EndHorizontal();
                        GUILayout.BeginHorizontal();
                    }
                }

                GUILayout.EndHorizontal();
            }

            GUILayout.Space(8f);

            {
                GUILayout.BeginHorizontal();

                if (GUILayout.Button("All", GUILayout.MinWidth(64)))
                {
                    for (int i = 0; i < _macro_state_arr.Length; ++i)
                    {
                        _macro_state_arr[i] = true;
                    }
                }

                if (GUILayout.Button("Clear", GUILayout.MinWidth(64)))
                {
                    for (int i = 0; i < _macro_state_arr.Length; ++i)
                    {
                        _macro_state_arr[i] = false;
                    }
                }

                GUILayout.FlexibleSpace();

                if (GUILayout.Button("Update", GUILayout.MinWidth(64)))
                {
                    List<string> useable_list = new List<string>();

                    useable_list.AddRange(_other_symbols);

                    for (int i = 0; i < _macro_state_arr.Length; ++i)
                    {
                        if (_macro_state_arr[i])
                        {
                            useable_list.Add(_macro_list[i]);
                        }
                    }

                    PlayerSettings.SetScriptingDefineSymbolsForGroup(_selected_build_target_group, String.Join(";", useable_list));
                }

                GUILayout.EndHorizontal();
            }
        }
    }
}
