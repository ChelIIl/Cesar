using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cesar
{
    public partial class CesarForm : Form
    {
        String s, t = "";
        int a;

        public CesarForm()
        {
            InitializeComponent();
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            cesar_txt.Clear();
            cesar_res_txt.Clear();
        }

        private void rashifr_btn_Click(object sender, EventArgs e)
        {
            if (step_txt.Text == "" || a > 32 || a < 0)
                MessageBox.Show("Введите сдвиг(до 32)!");

            else
            {
                t = "";
                cesar_res_txt.Clear();
                a = Convert.ToInt32(step_txt.Text);
                s = cesar_txt.Text;

                for (int i = 0; i < s.Length; i++)
                {
                    if (1103 >= s[i] + 1 - 1 && s[i] + 1 - 1 >= 1072)
                    {
                        if (s[i] - a < 1072)
                        {
                            t += 1104 - (1072 - (s[i] - a));
                        }
                        else
                        {
                            t += s[i] - a;
                        }
                    }
                    else if (1071 >= s[i] + 1 - 1 && s[i] + 1 - 1 >= 1040)
                    {
                        if (s[i] - a < 1040)
                        {
                            t += 1072 - (1040 - (s[i] - a));
                        }
                        else
                        {
                            t += s[i] - a;
                        }
                    }
                    else
                    {
                        t += s[i];
                    }
                }

                ShifrReplace();
            }
        }

        private void shifr_btn_Click(object sender, EventArgs e)
        {
            if (step_txt.Text == "" || a > 32 || a < 0)
                MessageBox.Show("Введите сдвиг(до 32)!");

            else
            {
                t = "";
                cesar_res_txt.Clear();
                a = Convert.ToInt32(step_txt.Text);
                s = cesar_txt.Text;

                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == 'ё')
                    {
                        if (1077 + a > 1103)
                        {
                            t += 1071 + (1077 + a - 1103);
                        }
                        else
                        {
                            t += 1077 + a;
                        }
                    }
                    else if (s[i] == 'Ё')
                    {
                        if (1045 + a > 1071)
                        {
                            t += 1039 + (1045 + a - 1071);
                        }
                        else
                        {
                            t += 1045 + a;
                        }
                    }
                    else if (1103 >= s[i] + 1 - 1 && s[i] + 1 - 1 >= 1072)
                    {
                        if (s[i] + a > 1103)
                        {
                            t += 1071 + (s[i] + a - 1103);
                        }
                        else
                        {
                            t += s[i] + a;
                        }
                    }
                    else if (1071 >= s[i] + 1 - 1 && s[i] + 1 - 1 >= 1040)
                    {
                        if (s[i] + a > 1071)
                        {
                            t += 1039 + (s[i] + a - 1071);
                        }
                        else
                        {
                            t += s[i] + a;
                        }
                    }
                    else
                    {
                        t += s[i];
                    }
                }

                ShifrReplace();
            }
        }

        private void ShifrReplace()
        {
            for (int i = 0; i < t.Length; i++)
            {
                t = t.Replace("1040", "А");
                t = t.Replace("1041", "Б");
                t = t.Replace("1042", "В");
                t = t.Replace("1043", "Г");
                t = t.Replace("1044", "Д");
                t = t.Replace("1045", "E");
                t = t.Replace("1046", "Ж");
                t = t.Replace("1047", "З");
                t = t.Replace("1048", "И");
                t = t.Replace("1049", "Й");
                t = t.Replace("1050", "К");
                t = t.Replace("1051", "Л");
                t = t.Replace("1052", "М");
                t = t.Replace("1053", "Н");
                t = t.Replace("1054", "О");
                t = t.Replace("1055", "П");
                t = t.Replace("1056", "Р");
                t = t.Replace("1057", "С");
                t = t.Replace("1058", "Т");
                t = t.Replace("1059", "У");
                t = t.Replace("1060", "Ф");
                t = t.Replace("1061", "Х");
                t = t.Replace("1062", "Ц");
                t = t.Replace("1063", "Ч");
                t = t.Replace("1064", "Ш");
                t = t.Replace("1065", "Щ");
                t = t.Replace("1066", "Ъ");
                t = t.Replace("1067", "Ы");
                t = t.Replace("1068", "Ь");
                t = t.Replace("1069", "Э");
                t = t.Replace("1070", "Ю");
                t = t.Replace("1071", "Я");
                t = t.Replace("1072", "а");
                t = t.Replace("1073", "б");
                t = t.Replace("1074", "в");
                t = t.Replace("1075", "г");
                t = t.Replace("1076", "д");
                t = t.Replace("1077", "е");
                t = t.Replace("1078", "ж");
                t = t.Replace("1079", "у");
                t = t.Replace("1080", "и");
                t = t.Replace("1081", "й");
                t = t.Replace("1082", "к");
                t = t.Replace("1083", "л");
                t = t.Replace("1084", "м");
                t = t.Replace("1085", "н");
                t = t.Replace("1086", "о");
                t = t.Replace("1087", "п");
                t = t.Replace("1088", "р");
                t = t.Replace("1089", "с");
                t = t.Replace("1090", "т");
                t = t.Replace("1091", "у");
                t = t.Replace("1092", "ф");
                t = t.Replace("1093", "х");
                t = t.Replace("1094", "ц");
                t = t.Replace("1095", "х");
                t = t.Replace("1096", "ш");
                t = t.Replace("1097", "щ");
                t = t.Replace("1098", "ъ");
                t = t.Replace("1099", "ы");
                t = t.Replace("1100", "ь");
                t = t.Replace("1101", "э");
                t = t.Replace("1102", "ю");
                t = t.Replace("1103", "я");
            }

            cesar_res_txt.Text = t;
        }
    }
}
