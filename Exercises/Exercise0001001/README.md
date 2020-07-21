# 自定义编辑器

* `ChangeCheckEditorWindow`   
  
  只监控 `EditorGUI.BeginChangeCheck()` 与 `EditorGUI.EndChangeCheck()` 之间的控件的变化   
  `GUI.changed` 监控全部控件的变化

* `DisabledGroupEditorWindow`   
  
  __Enable/Disable__ `EditorGUI.BeginDisabledGroup()` 与 `EditorGUI.EndDisabledGroup()` 之间的控件

* `FoldoutHeaderGroupEditorWindow`   
  
  折叠 `EditorGUI.BeginFoldoutHeaderGroup()` 与 `EditorGUI.EndFoldoutHeaderGroup()` 之间的控件
