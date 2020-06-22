using UnityEngine;

namespace sample.attributes
{

    /// <summary>
    /// 默认情况下<c>MonoBehaviour</c>子类只在播放模式下执行，使用<c>[ExecuteInEditMode]</c>后，
    /// 即使引擎编辑器不在播放模式，<c>MonoBehaviour</c>实例的回调函数也会被执行。
    /// 以下函数不会像播放模式下持续调用：
    /// <para><c>Update()</c>：当且只当场景发生改变时才调用</para>
    /// <para />
    /// <para><c>OnGUI()</c>：当且只当游戏窗口收到事件时才调用</para>
    /// <para />
    /// <para><c>OnRenderObject()</c>与其它渲染回调函数：当且只当场景窗口或游戏窗口发生重绘时才调用</para>
    /// </summary>
    [ExecuteInEditMode]
    [AddComponentMenu("Custom/PlayerWatcher", 0)]
    [RequireComponent(typeof(SelfInfo))]
    public class PlayerWatcher : MonoBehaviour
    {
        private double _time_mark = 0;
        public void Awake()
        {
            Debug.Log("I will awake in edit/play mode!");
        }

        public void Update()
        {
            if (60 > Time.realtimeSinceStartup - this._time_mark)
            {
                return;
            }
            _time_mark = Time.realtimeSinceStartup;
            Debug.Log("I will update in edit/play mode!");
        }

        [GUITarget(0, 1, new int[] { 2 })]
        void OnGUI()
        {
            GUI.Label(new Rect(10, 10, 300, 100), "Visible on Dispaly 1/2/3 only");
        }
    }
}