namespace WffCalDotNet.Model
{
    ////
    /// ----------------------------------------------------------------
    /// Copyright @BigWang 2023 All rights reserved
    /// Author      : BigWang
    /// Created Time: 2023/4/1 21:19:59
    /// Description :
    /// ----------------------------------------------------------------
    /// Version      Modified Time              Modified By     Modified Content
    /// V1.0.0.0     2023/4/1 21:19:59                     BigWang         首次编写         
    ///
    public class InvParam
    {
        /// <summary>
        /// 待反演数据
        /// 每行为一组数据
        /// </summary>
        public double[,] EH { get; set; }

        /// <summary>
        /// Tw 时间
        /// </summary>
        public double[] Tau1 { get; set; }

        /// <summary>
        /// Tw 个数
        /// </summary>
        public int Nw { get; set; }

        /// <summary>
        /// T2 采集时间
        /// </summary>
        public double[] Tau2 { get; set; }

        /// <summary>
        /// 回波个数
        /// </summary>
        public int NECH { get; set; }

        /// <summary>
        /// 最小弛豫时间
        /// </summary>
        public double Tmin { get; set; }

        /// <summary>
        /// 最大弛豫时间
        /// </summary>
        public double Tmax { get; set; }

        /// <summary>
        /// 正则化因子
        /// </summary>
        public double Alpha { get; set; }

        /// <summary>
        /// 反演点数
        /// </summary>
        public int Nt { get; set; }

        /// <summary>
        /// 反演模型：1表示饱和恢复，2表示反转恢复
        /// </summary>
        public int InvModel { get; set; }

        /// <summary>
        /// 反演结果 T2 -T1 分布
        /// </summary>
        public double[,] T2T1Dist { get; set; }

        /// <summary>
        /// 拟合结果
        /// </summary>
        public double[,] EHfit { get; set; }

        /// <summary>
        /// 弛豫时间
        /// </summary>
        public double[] T { get; set; }

        /// <summary>
        /// T1 分布，累积
        /// </summary>
        public double[] T1Dist { get; set; }

        /// <summary>
        /// T2 分布，累积
        /// </summary>
        public double[] T2Dist { get; set; }

        /// <summary>
        /// 相对误差
        /// </summary>
        public double ReError { get; set; }
    }
}