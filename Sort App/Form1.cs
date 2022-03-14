using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sort_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Cocktailsort : Cocktail sort描述
        public void Cocktailsort(int[] list)
        {
            int n = list.Length;    //n為數列內數值總數
            int temp;   //temp為比較中的暫存變數

            for (int i = 1; i < n; i++)     //外層迴圈:總共進行n-1輪比較
            {
                if (i % 2 != 0)     //內層迴圈1:若i為奇數，則向右兩兩比較，將最大值擠壓至右邊
                {
                    for (int j = (i + 1) / 2; j < n - ((i + 1) / 2) + 1; j++)
                    {
                        if (list[j] < list[j - 1])
                        {
                            temp = list[j];
                            list[j] = list[j - 1];
                            list[j - 1] = temp;
                        }
                    }
                }

                else        //內層迴圈2:若i為偶數，則向左兩兩比較，將最小值擠壓至右邊
                {
                    for (int j = i / 2; j < n - (i / 2); j++)
                    {
                        if (list[n - j - 1] < list[n - j - 2])
                        {
                            temp = list[n - j - 1];
                            list[n - j - 1] = list[n - j - 2];
                            list[n - j - 2] = temp;
                        }
                    }
                }

                Sort_output.Text += Trans(list) + "\n";         //輸出排序過程
            }
        }

        //Trans : 將int sequence轉換成string
        public string Trans(int[] list)
        {
            string output_string = "";
            for (int i = 0; i < list.Length; i++)
            {
                output_string = output_string + list[i] + " ";
            }

            return output_string;
        }

        //Sort_Button_Click : 將input的string進行判斷，格式錯誤回報error，格式正確進行排序
        private void Sort_Button_Click(object sender, EventArgs e)
        {
            string input_string = Number_input.Text;
            string[] input_string_split = input_string.Split(' ');
            int[] list = new int[input_string_split.Length];

            for(int i = 0; i < list.Length; i++)
            {
                if (input_string_split[i].All(char.IsDigit))     //判斷輸入是否為數字，若是則存取，若不是則中斷
                {
                    list[i] = Int32.Parse(input_string_split[i]);
                }
                else
                {
                    Sort_output.Text = "error";
                    return;
                }
            }

            Sort_output.Text += "排序過程 : \n";

            Cocktailsort(list);
            
            Sort_output.Text += "\n排序結果 : \n" + Trans(list) + "\n\n";
        }

        //random_generate_Click : 依據輸入的條件隨機生成數列，若條件不符規定則會回傳error
        private void random_generate_Click(object sender, EventArgs e)
        {
            Number_input.Text = "";

            string min_input = Random_minimum.Text;
            int min;
            if (min_input.All(char.IsDigit))
            {
                min = Int32.Parse(min_input);
            }
            else
            {
                Sort_output.Text = "error";
                return;
            }

            string max_input = Random_maximum.Text;
            int max;
            if (max_input.All(char.IsDigit))
            {
                max = Int32.Parse(max_input);
            }
            else
            {
                Sort_output.Text = "error";
                return;
            }

            string ranNum_input = Random_number.Text;
            int ranNum;
            if (ranNum_input.All(char.IsDigit))
            {
                ranNum = Int32.Parse(ranNum_input);
            }
            else
            {
                Sort_output.Text = "error";
                return;
            }

            if(max <= min)
            {
                Sort_output.Text = "error";
                return;
            }

            var temp = new Random();
            for(int i = 0;i < ranNum;i++)
            {
                Number_input.Text += temp.Next(min, max + 1);
                if(i + 1 < ranNum)
                {
                    Number_input.Text += " ";
                }
            }
        }

        //Reset_button_Click : 重置輸入欄和結果輸出欄
        private void Reset_button_Click(object sender, EventArgs e)
        {
            Number_input.Text = "";
            Sort_output.Text = "";
        }
    }
}
