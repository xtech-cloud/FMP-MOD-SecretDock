using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using LibMVCS = XTC.FMP.LIB.MVCS;
using XTC.FMP.MOD.SecretDock.LIB.Proto;
using XTC.FMP.MOD.SecretDock.LIB.MVCS;
using System.Collections;

namespace XTC.FMP.MOD.SecretDock.LIB.Unity
{
    /// <summary>
    /// 实例类
    /// </summary>
    public class MyInstance : MyInstanceBase
    {
        public class UiReference
        {
            public GameObject dockRoot;
        }

        private UiReference uiReference_ = new UiReference();
        private GameObject objListener_;

        public MyInstance(string _uid, string _style, MyConfig _config, MyCatalog _catalog, LibMVCS.Logger _logger, Dictionary<string, LibMVCS.Any> _settings, MyEntryBase _entry, MonoBehaviour _mono, GameObject _rootAttachments)
            : base(_uid, _style, _config, _catalog, _logger, _settings, _entry, _mono, _rootAttachments)
        {
        }

        /// <summary>
        /// 当被创建时
        /// </summary>
        /// <remarks>
        /// 可用于加载主题目录的数据
        /// </remarks>
        public void HandleCreated()
        {
            uiReference_.dockRoot = rootUI.transform.Find("dock").gameObject;

            objListener_ = new GameObject(this.uid + "_listener");
            objListener_.transform.SetParent(rootUI.transform.parent);
            var listener = objListener_.AddComponent<ListenerBehaviour>();
            listener.wakeCount = style_.clickArea.wakeCount;
            listener.tickTime = style_.clickArea.tickTime;
            listener.x = style_.clickArea.x;
            listener.y = style_.clickArea.y;
            listener.width = style_.clickArea.width;
            listener.height = style_.clickArea.height;
            listener.onTrigger = () =>
            {
                foreach (var subject in style_.clickArea.subjects)
                {
                    publishPreloadSubject(subject);
                }
            };
        }

        /// <summary>
        /// 当被删除时
        /// </summary>
        public void HandleDeleted()
        {
            if (null != objListener_)
            {
                GameObject.Destroy(objListener_);
                objListener_ = null;
            }
        }

        /// <summary>
        /// 当被打开时
        /// </summary>
        /// <remarks>
        /// 可用于加载内容目录的数据
        /// </remarks>
        public void HandleOpened(string _source, string _uri)
        {
            rootUI.gameObject.SetActive(true);
        }

        /// <summary>
        /// 当被关闭时
        /// </summary>
        public void HandleClosed()
        {
            rootUI.gameObject.SetActive(false);
        }

        protected void publishPreloadSubject(MyConfig.Subject _subject)
        {
            var data = new Dictionary<string, object>();
            foreach (var parameter in _subject.parameters)
            {
                if (parameter.type.Equals("string"))
                    data[parameter.key] = parameter.value;
                else if (parameter.type.Equals("int"))
                    data[parameter.key] = int.Parse(parameter.value);
                else if (parameter.type.Equals("float"))
                    data[parameter.key] = float.Parse(parameter.value);
                else if (parameter.type.Equals("bool"))
                    data[parameter.key] = bool.Parse(parameter.value);
            }
            (entry_ as MyEntry).getDummyModel().Publish(_subject.message, data);
        }
    }
}
