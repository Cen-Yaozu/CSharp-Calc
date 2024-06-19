using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Calc
{
    public partial class CalcForm : Form
    {
        private string strOutput = "";
        private double lNumFormer = 0;//前一个操作数
        private double lNumTemp = 0;//临时变量
        private double lResult = 0;//结果
        private char cOperator;//操作符
        private bool bDotClicked = false;//用于标记小数点是否被按下
        //private uint decimalIndex = 0;//用于标记当前小数点后精度位数，如3.14的decimalIndex==2
        double lastDecimalNum = 1;//最近一次点击的小数精度，即小数最后一位精度，如0.01

        public CalcForm()
        {
            InitializeComponent();
            //数字按钮0~9
            // 定义一个事件处理程序
            EventHandler eh = new EventHandler(Numbers_Click);
            // 将事件处理程序添加到button_num_0的点击事件中
            button_num_0.Click += eh;
            // 将事件处理程序添加到button_num_1的点击事件中
            button_num_1.Click += eh;
            // 将事件处理程序添加到button_num_2的点击事件中
            button_num_2.Click += eh;
            // 将事件处理程序添加到button_num_3的点击事件中
            button_num_3.Click += eh;
            // 将事件处理程序添加到button_num_4的点击事件中
            button_num_4.Click += eh;
            // 将事件处理程序添加到button_num_5的点击事件中
            button_num_5.Click += eh;
            // 将事件处理程序添加到button_num_6的点击事件中
            button_num_6.Click += eh;
            // 将事件处理程序添加到button_num_7的点击事件中
            button_num_7.Click += eh;
            // 将事件处理程序添加到button_num_8的点击事件中
            button_num_8.Click += eh;
            // 将事件处理程序添加到button_num_9的点击事件中
            button_num_9.Click += eh;

            //运算符+、-、*、/
            EventHandler eh2 = new EventHandler(Operators_Click);
            button_add.Click += eh2;
            button_sub.Click += eh2;
            button_mul.Click += eh2;
            button_div.Click += eh2;
            button_mod.Click += eh2;
        }

        private void CalcForm_Load(object sender, EventArgs e)
        {

        }
        //****数字按钮0-9
        private void button_num_0_Click(object sender, EventArgs e)
        {
            //功能实现代码位于Numbers_Click（）函数
        }

        private void button_num_1_Click(object sender, EventArgs e)
        {
            //功能实现代码位于Numbers_Click（）函数
        }

        private void button_num_2_Click(object sender, EventArgs e)
        {
            //功能实现代码位于Numbers_Click（）函数
        }

        private void button_num_3_Click(object sender, EventArgs e)
        {
            //功能实现代码位于Numbers_Click（）函数
        }

        private void button_num_4_Click(object sender, EventArgs e)
        {
            //功能实现代码位于Numbers_Click（）函数
        }

        private void button_num_5_Click(object sender, EventArgs e)
        {
            //功能实现代码位于Numbers_Click（）函数
        }

        private void button_num_6_Click(object sender, EventArgs e)
        {
            //功能实现代码位于Numbers_Click（）函数
        }

        private void button_num_7_Click(object sender, EventArgs e)
        {
            //功能实现代码位于Numbers_Click（）函数
        }

        private void button_num_8_Click(object sender, EventArgs e)
        {
            //功能实现代码位于Numbers_Click（）函数
        }

        private void button_num_9_Click(object sender, EventArgs e)
        {
            //功能实现代码位于Numbers_Click（）函数
        }

        //****操作符+、-、*、/
        private void button_add_Click(object sender, EventArgs e)
        {
            //功能实现代码位于Operators_Click（）函数
        }

        private void button_sub_Click(object sender, EventArgs e)
        {
            //功能实现代码位于Operators_Click（）函数
        }

        private void button_mul_Click(object sender, EventArgs e)
        {
            //功能实现代码位于Operators_Click（）函数
        }

        private void button_div_Click(object sender, EventArgs e)
        {
            //功能实现代码位于Operators_Click（）函数
        }
        private void button_mod_Click(object sender, EventArgs e)
        {
            //功能实现代码位于Operators_Click（）函数
        }


        //****等于号=
        private void button_enter_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cOperator)
                {
                    case '+':
                        //计算并检测数据是否越界 将结果赋给lResult（前一个数和临时变量相加 lNumFormer会在加减乘除的操作时存储）
                        checked { lResult = lNumFormer + lNumTemp; }
                        break;
                    case '-':
                        checked { lResult = lNumFormer - lNumTemp; }
                        break;
                    case '*':
                        checked { lResult = lNumFormer * lNumTemp; };
                        break;
                    case '/':
                        checked { lResult = lNumFormer / lNumTemp; };
                        break;
                    case '%':
                        checked { lResult = lNumFormer % lNumTemp; };
                        break;
                }
            }
            catch
            {
                MessageBox.Show("运算结果溢出");
            }

            txtOutput.Text = lResult.ToString();
            //清空变量
            lNumFormer = 0;//前一个操作数
            lNumTemp = 0;//临时变量
            lResult = 0;//结果
            cOperator = '\0';//操作符
            strOutput = "";
            bDotClicked = false;
            lastDecimalNum = 1;
        }

        //****清空键CE
        private void button_ce_Click(object sender, EventArgs e)
        {
            //清空变量
            lNumFormer = 0;//前一个操作数
            lNumTemp = 0;//临时变量
            lResult = 0;//结果
            cOperator = '\0';//操作符
            strOutput = "";
            bDotClicked = false;
            lastDecimalNum = 1;

            //清空页面显示
            txtOutput.Text = "";
        }

        //****小数点.
        private void button_dot_Click(object sender, EventArgs e)
        {
            if (!bDotClicked)
            {
                strOutput += ".";
                txtOutput.Text = strOutput;
                bDotClicked = true;
            }
        }

        //集中处理按钮点击事件
        //****数字按钮0-9
        private void Numbers_Click(object sender, EventArgs e)
        {
            //根据按钮上的文本，获取点击的小数数值
            string strClickNum = ((Button)sender).Text;
            try
            {
                //判断点击的按钮是否是小数点按钮
                if (bDotClicked)
                {
                    //得出点击的小数数值
                    //decimalIndex++;
                    lastDecimalNum *= 0.1;
                    //将点击的小数数值累加到lNumTemp中，并且使用checked关键字，防止溢出
                    checked { lNumTemp = lNumTemp + long.Parse(strClickNum) * lastDecimalNum; }
                }
                else
                {
                    //如果是整数按钮，则直接相乘10
                    checked { lNumTemp = lNumTemp * 10 + long.Parse(strClickNum); }
                }
            }
            catch
            {
                //貌似double型并不会轻易溢出
                MessageBox.Show("数据溢出");
            }
            //将计算结果输出到文本框
            txtOutput.Text = lNumTemp.ToString();
            //将点击的按钮的文本添加到strOutput中
            strOutput += strClickNum;
            //strOutput = lNumTemp.ToString();
            //将strOutput输出到文本框
            txtOutput.Text = strOutput;

        }

        //集中处理按钮点击事件
        //****操作符+、-、*、/、%
        private void Operators_Click(object sender, EventArgs e)
        {
            //根据点击的按钮，获取操作符
            string strClickOp = ((Button)sender).Text;
            cOperator = strClickOp[0];//strClickOp长度为1
            //存储上一个数字
            lNumFormer = lNumTemp;
            //清空当前数字
            lNumTemp = 0;
            //将操作符添加到输出字符串
            strOutput += cOperator.ToString();
            //显示输出字符串
            txtOutput.Text = strOutput;
            //小数点点击状态重置
            bDotClicked = false;
            //存储小数点后的数字
            lastDecimalNum = 1;
        }

        //键盘按键
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // 如果是热键，则返回True；否则，返回False
            switch (keyData)
            {
                //****数字键
                case Keys.NumPad0:
                    button_num_0.Focus();
                    button_num_0.PerformClick();
                    return true;
                 //****小数点键
                case Keys.NumPad1:
                    button_num_1.Focus();
                    button_num_1.PerformClick();
                    return true;
                case Keys.NumPad2:
                    button_num_2.Focus();
                    button_num_2.PerformClick();
                    return true;
                case Keys.NumPad3:
                    button_num_3.Focus();
                    button_num_3.PerformClick();
                    return true;
                case Keys.NumPad4:
                    button_num_4.Focus();
                    button_num_4.PerformClick();
                    return true;
                case Keys.NumPad5:
                    button_num_5.Focus();
                    button_num_5.PerformClick();
                    return true;
                case Keys.NumPad6:
                    button_num_6.Focus();
                    button_num_6.PerformClick();
                    return true;
                case Keys.NumPad7:
                    button_num_7.Focus();
                    button_num_7.PerformClick();
                    return true;
                case Keys.NumPad8:
                    button_num_8.Focus();
                    button_num_8.PerformClick();
                    return true;
                case Keys.NumPad9:
                    button_num_9.Focus();
                    button_num_9.PerformClick();
                    return true;
                case Keys.Add:
                    button_add.Focus();
                    button_add.PerformClick();
                    return true;
                case Keys.Subtract:
                    button_sub.Focus();
                    button_sub.PerformClick();
                    return true;
                case Keys.Multiply:
                    button_mul.Focus();
                    button_mul.PerformClick();
                    return true;
                case Keys.Divide:
                    button_div.Focus();
                    button_div.PerformClick();
                    return true;
                case Keys.Enter:
                    button_enter.Focus();
                    button_enter.PerformClick();
                    return true;
                case Keys.Escape:
                    button_ce.Focus();
                    button_ce.PerformClick();
                    return true;
                case Keys.Decimal:
                    button_dot.Focus();
                    button_dot.PerformClick();
                    return true;
                default:
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }


    }
}
