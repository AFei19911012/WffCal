using System;
using System.Diagnostics;
using System.Windows;
using WffCalDotNet;
using WffCalDotNet.Model;

namespace TestUnit
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // 读取数据
            double[,] EH = WffCal.LoadMat(Environment.CurrentDirectory + "\\EH_T1T2.txt");
            double[] tau1 = WffCal.LoadVec(Environment.CurrentDirectory + "\\tau1.txt");
            double[] tau2 = WffCal.LoadVec(Environment.CurrentDirectory + "\\tau2.txt");
            int Nw = tau1.Length;
            int NECH = tau2.Length;
            int Nt = 64;
            double Tmin = 0.01;
            double Tmax = 10000;
            int invModel = 2;
            double alpha = 1;

            // 初始化反演参数
            InvParam param = new InvParam
            {
                EH = EH,
                Tau1 = tau1,
                Tau2 = tau2,
                Nw = Nw,
                NECH = NECH,
                Nt = Nt,
                Tmin = Tmin,
                Tmax = Tmax,
                InvModel = invModel,
                Alpha = alpha,
            };

            // 记录反演时间
            Stopwatch watch = new Stopwatch();
            watch.Start();
            // 调用接口
            WffCal.InvT1T2(ref param);
            watch.Stop();
            _ = LB_Log.Items.Add(string.Format("反演耗时：{0}ms", watch.ElapsedMilliseconds));

            // 保存反演结果
            param.T2T1Dist.Save(Environment.CurrentDirectory + "\\T2T1Dist.txt");
            param.T2Dist.Save(Environment.CurrentDirectory + "\\T2Dist.txt");
        }
    }
}