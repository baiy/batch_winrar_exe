using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace winrar
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            //定时器
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Enabled = true;
            timer.Interval = 1000;//执行间隔时间,单位为毫秒  
            timer.Start();
            timer.Elapsed += new System.Timers.ElapsedEventHandler(Timer1_Elapsed);
        }

        private void Timer1_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            //程序启动标识
            if (this.button1.Text != "开始")
            {
                // 得到 hour minute second  如果等于某个值就开始执行某个程序。  
                int intHour = e.SignalTime.Hour;
                int intMinute = e.SignalTime.Minute;
                int intSecond = e.SignalTime.Second;

                //压缩
                if (intHour == this.dateTimePicker1.Value.Hour && intMinute == this.dateTimePicker1.Value.Minute && intSecond == this.dateTimePicker1.Value.Second)
                {
                    this.add_remarks("开始压缩");
                    this.rar();
                }

                //移动
                if (intHour == this.dateTimePicker2.Value.Hour && intMinute == this.dateTimePicker2.Value.Minute && intSecond == this.dateTimePicker2.Value.Second)
                {
                    this.add_remarks("开始移动");
                    this.move();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.Text = this.button1.Text == "关闭" ? "开始" : "关闭";
        }

        //移动文件
        private void move()
        {
   
            //移动目录
            string dirPath = this.filedir.Text;
            FileObj.MoveDir(dirPath, this.movefiledir.Text);
 
            string zipPath = this.exepath.Text;
            FileObj.MoveDir(zipPath, this.moveexepath.Text);
        }

        //压缩文件
        private void rar()
        {
            string dirPath = this.filedir.Text;
            string zipPath = this.exepath.Text;
            string smarkPath = this.smarkPath.Text;

            if (dirPath == "" || zipPath == "" || smarkPath == "")
            {
                // MessageBox.Show(System.Diagnostics.Process.GetProcessesByName("WinRAR").Length.ToString());
                MessageBox.Show("dirPath || zipPath smarkPath 不能为空");
            }
            else
            {
                List<List<string>> getdir = this.getdir(dirPath);
                int count = 0;
                int i = 0;
                this.add_remarks("开始压缩");
                while (count != getdir.Count && i != getdir.Count)
                {
                    if (System.Diagnostics.Process.GetProcessesByName("WinRAR").Length < 1)
                    {
                        this.winRAR(getdir[i][0], zipPath, getdir[i][1], smarkPath);
                        this.add_remarks("进度:" + (i + 1));
                        i++;
                    }
                    count = this.countpath(zipPath).Length;
                }
                this.add_remarks("全部完成! ");
            }
        }

        /// <summary>
        /// 生成自解压文件
        /// </summary>
        /// <param name="dirPath">打包源路径</param>
        /// <param name="zipPath">压缩包存放位置</param>
        /// <param name="name">压缩包名</param>
        /// <param name="smarkPath">备注文件</param>
        /// <returns></returns>
        public bool winRAR(string dirPath, string zipPath, string name, string smarkPath)
        {
            try
            {
                System.Diagnostics.Process proc = new System.Diagnostics.Process();

                proc.EnableRaisingEvents = false;

                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\WinRAR.exe");

                proc.StartInfo.FileName = key.GetValue("").ToString();
                zipPath = "\"" + zipPath + "\\" + name + "\"";
                dirPath = "\"" + dirPath + "\"";
                proc.StartInfo.Arguments = "a -z" + smarkPath + " -sfx -O+ -ep1 " + zipPath + " " + dirPath;
                //this.add_remarks("a -z" + smarkPath + " -sfx -O+ -ep1 " + zipPath + "\\" + name + " " + dirPath + "");
                proc.Start();
                if (proc.HasExited)
                {
                    int iExitCode = proc.ExitCode;
                    if (iExitCode == 0)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                this.add_remarks("错误:" + ex.Message);
                return false;
            }
        }

        private void selectdir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            this.filedir.Text = path.SelectedPath;
            if (path.SelectedPath != "")
            {
                DirectoryInfo[] count = this.countpath(path.SelectedPath.ToString());
                this.add_remarks("需要压缩的文件夹个数为: " + count.Length.ToString());
            }

        }


        private void selectexepath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            this.exepath.Text = path.SelectedPath;
        }

        private void selectmovefiledir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            this.movefiledir.Text = path.SelectedPath;
        }


        private void slectmoveexepath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            this.moveexepath.Text = path.SelectedPath;
        }

        private void selectsmarkPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            this.smarkPath.Text = file.FileName;
        }

        private DirectoryInfo[] countpath(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            return dir.GetDirectories();
        }



        private List<List<string>> getdir(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            List<List<string>> dirlist = new List<List<string>>();
            foreach (DirectoryInfo dChild in dir.GetDirectories("*"))
            {
                List<string> lists = new List<string>();
                lists.Add(dChild.FullName);
                lists.Add(dChild.Name);
                dirlist.Add(lists);
            }
            return dirlist;
        }

        private void add_remarks(string str)
        {
            if (this.remarks.Text.Length > 300)
            {
                this.remarks.Text = "";
            }
            this.remarks.Text = this.remarks.Text + str + "\r\n";
            
            this.remarks.Update();
            this.remarks.Select(this.remarks.Text.Length, 0);
            this.remarks.ScrollToCaret();

            //写入日志
            DateTime dt = DateTime.Now;
            StreamWriter sw = File.AppendText("log.txt");
            string w = "[" + dt.ToLocalTime().ToString() + "] =>" + str + "\r\n";
            sw.Write(w);
            sw.Close();
        }

    }
}
