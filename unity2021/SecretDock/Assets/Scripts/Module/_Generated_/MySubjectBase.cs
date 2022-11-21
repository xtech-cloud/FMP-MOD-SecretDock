
//*************************************************************************************
//   !!! Generated by the fmp-cli 1.62.0.  DO NOT EDIT!
//*************************************************************************************

namespace XTC.FMP.MOD.SecretDock.LIB.Unity
{
    public class MySubjectBase
    {
        /// <summary>
        /// 创建
        /// </summary>
        /// <example>
        /// var data = new Dictionary<string, object>();
        /// data["uid"] = "default";
        /// data["style"] = "default";
        /// model.Publish(/XTC/SecretDock/Create, data);
        /// </example>
        public const string Create = "/XTC/SecretDock/Create";

        /// <summary>
        /// 打开
        /// </summary>
        /// <remarks>
        /// 先加载资源，然后显示
        /// </remarks>
        /// <example>
        /// var data = new Dictionary<string, object>();
        /// data["uid"] = "default";
        /// data["source"] = "file";
        /// data["uri"] = "";
        /// data["delay"] = 0f;
        /// model.Publish(/XTC/SecretDock/Open, data);
        /// </example>
        public const string Open = "/XTC/SecretDock/Open";

        /// <summary>
        /// 显示
        /// </summary>
        /// <remarks>
        /// 仅显示，不执行其他任何操作
        /// </remarks>
        /// <example>
        /// var data = new Dictionary<string, object>();
        /// data["uid"] = "default";
        /// data["delay"] = 0f;
        /// model.Publish(/XTC/SecretDock/Show, data);
        /// </example>
        public const string Show = "/XTC/SecretDock/Show";

        /// <summary>
        /// 隐藏
        /// </summary>
        /// <remarks>
        /// 仅隐藏，不执行其他任何操作
        /// </remarks>
        /// <example>
        /// var data = new Dictionary<string, object>();
        /// data["uid"] = "default";
        /// data["delay"] = 0f;
        /// model.Publish(/XTC/SecretDock/Hide, data);
        /// </example>
        public const string Hide = "/XTC/SecretDock/Hide";

        /// <summary>
        /// 关闭
        /// </summary>
        /// <remarks>
        /// 先隐藏，然后释放资源
        /// </remarks>
        /// <example>
        /// var data = new Dictionary<string, object>();
        /// data["uid"] = "default";
        /// data["delay"] = 0f;
        /// model.Publish(/XTC/SecretDock/Close, data);
        /// </example>
        public const string Close = "/XTC/SecretDock/Close";

        /// <summary>
        /// 销毁
        /// </summary>
        /// <example>
        /// var data = new Dictionary<string, object>();
        /// data["uid"] = "default";
        /// model.Publish(/XTC/SecretDock/Close, data);
        /// </example>
        public const string Delete = "/XTC/SecretDock/Delete";
    }
}