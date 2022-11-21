
//*************************************************************************************
//   !!! Generated by the fmp-cli 1.62.0.  DO NOT EDIT!
//*************************************************************************************

using System.Threading;
using System.Threading.Tasks;
using XTC.FMP.LIB.MVCS;

namespace XTC.FMP.MOD.SecretDock.LIB.Bridge
{
    /// <summary>
    /// Healthy的视图桥接层（协议部分）
    /// 处理UI的事件
    /// </summary>
    public interface IHealthyViewProtoBridge : View.Facade.Bridge
    {

        /// <summary>
        /// 处理Echo的提交
        /// </summary>
        Task<Error> OnEchoSubmit(IDTO _dto, object? _context);


    }
}

