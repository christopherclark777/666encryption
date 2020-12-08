using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Media;
using System.Timers;

namespace App_666_Encryption_v1._0._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();





        }

        private void exigtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Title = "Select A File";
            openDialog.Filter = "Text Files (*.txt)|*.txt" + "|" +
                                "Image Files (*.png;*.jpg)|*.png;*.jpg" + "|" +
                                "All Files (*.*)|*.*";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                textBox3.Text = openDialog.FileName;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //////////////////////////////////////////////////////////////////////////////////////////////
            //Browse for a file to open and encrypt or decrypt.

            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox4.Text = openFileDialog1.FileName;


            }
            //////////////////////////////////////////////////////////////////////////////////////////////
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {




        }

        private void button1_Click(object sender, EventArgs e)
        {

            //666 Encryption Algorithm | Encrypt


            System.IO.StreamReader file = new System.IO.StreamReader(textBox3.Text);








            while (file.Peek() >= 0)
            {
                int asc = (char)file.Read();
                string message = Convert.ToString(asc);




                if (message.Length == 2)
                {




                    Random rnd = new Random();



                    // int k = rnd.Next(260, 999);

                    int k = Convert.ToInt16(textBox5.Text);


                    int num1 = k - 1;
                    int num2 = k - 2;
                    int num3 = k - 3;
                    int num4 = k - 4;
                    int num5 = k - 5;
                    int num6 = k - 6;
                    int num7 = k - 7;
                    int num8 = k - 8;
                    int num9 = k - 9;
                    int num10 = k - 10;
                    int num11 = k - 11;
                    int num12 = k - 12;
                    int num13 = k - 13;
                    int num14 = k - 14;
                    int num15 = k - 15;
                    int num16 = k - 16;
                    int num17 = k - 17;
                    int num18 = k - 18;
                    int num19 = k - 19;
                    int num20 = k - 20;
                    int num21 = k - 21;
                    int num22 = k - 22;
                    int num23 = k - 23;
                    int num24 = k - 24;
                    int num25 = k - 25;
                    int num26 = k - 26;
                    int num27 = k - 27;
                    int num28 = k - 28;
                    int num29 = k - 29;
                    int num30 = k - 30;
                    int num31 = k - 31;
                    int num32 = k - 32;
                    int num33 = k - 33;
                    int num34 = k - 34;
                    int num35 = k - 35;
                    int num36 = k - 36;
                    int num37 = k - 37;
                    int num38 = k - 38;
                    int num39 = k - 39;
                    int num40 = k - 40;
                    int num41 = k - 41;
                    int num42 = k - 42;
                    int num43 = k - 43;
                    int num44 = k - 44;
                    int num45 = k - 45;
                    int num46 = k - 46;
                    int num47 = k - 47;
                    int num48 = k - 48;
                    int num49 = k - 49;
                    int num50 = k - 50;
                    int num51 = k - 51;
                    int num52 = k - 52;
                    int num53 = k - 53;
                    int num54 = k - 54;
                    int num55 = k - 55;
                    int num56 = k - 56;
                    int num57 = k - 57;
                    int num58 = k - 58;
                    int num59 = k - 59;
                    int num60 = k - 60;
                    int num61 = k - 61;
                    int num62 = k - 62;
                    int num63 = k - 63;
                    int num64 = k - 64;
                    int num65 = k - 65;
                    int num66 = k - 66;
                    int num67 = k - 67;
                    int num68 = k - 68;
                    int num69 = k - 69;
                    int num70 = k - 70;
                    int num71 = k - 71;
                    int num72 = k - 72;
                    int num73 = k - 73;
                    int num74 = k - 74;
                    int num75 = k - 75;
                    int num76 = k - 76;
                    int num77 = k - 77;
                    int num78 = k - 78;
                    int num79 = k - 79;
                    int num80 = k - 80;
                    int num81 = k - 81;
                    int num82 = k - 82;
                    int num83 = k - 83;
                    int num84 = k - 84;
                    int num85 = k - 85;
                    int num86 = k - 86;
                    int num87 = k - 87;
                    int num88 = k - 88;
                    int num89 = k - 89;
                    int num90 = k - 90;
                    int num91 = k - 91;
                    int num92 = k - 92;
                    int num93 = k - 93;
                    int num94 = k - 94;
                    int num95 = k - 95;
                    int num96 = k - 96;
                    int num97 = k - 97;
                    int num98 = k - 98;
                    int num99 = k - 99;
                    int num100 = k - 100;
                    int num101 = k - 101;
                    int num102 = k - 102;
                    int num103 = k - 103;
                    int num104 = k - 104;
                    int num105 = k - 105;
                    int num106 = k - 106;
                    int num107 = k - 107;
                    int num108 = k - 108;
                    int num109 = k - 109;
                    int num110 = k - 110;
                    int num111 = k - 111;
                    int num112 = k - 112;
                    int num113 = k - 113;
                    int num114 = k - 114;
                    int num115 = k - 115;
                    int num116 = k - 116;
                    int num117 = k - 117;
                    int num118 = k - 118;
                    int num119 = k - 119;
                    int num120 = k - 120;
                    int num121 = k - 121;
                    int num122 = k - 122;
                    int num123 = k - 123;
                    int num124 = k - 124;
                    int num125 = k - 125;
                    int num126 = k - 126;
                    int num127 = k - 127;
                    int num128 = k - 128;
                    int num129 = k - 129;
                    int num130 = k - 130;
                    int num131 = k - 131;
                    int num132 = k - 132;
                    int num133 = k - 133;
                    int num134 = k - 134;
                    int num135 = k - 135;
                    int num136 = k - 136;
                    int num137 = k - 137;
                    int num138 = k - 138;
                    int num139 = k - 139;
                    int num140 = k - 140;
                    int num141 = k - 141;
                    int num142 = k - 142;
                    int num143 = k - 143;
                    int num144 = k - 144;
                    int num145 = k - 145;
                    int num146 = k - 146;
                    int num147 = k - 147;
                    int num148 = k - 148;
                    int num149 = k - 149;
                    int num150 = k - 150;
                    int num151 = k - 151;
                    int num152 = k - 152;
                    int num153 = k - 153;
                    int num154 = k - 154;
                    int num155 = k - 155;
                    int num156 = k - 156;
                    int num157 = k - 157;
                    int num158 = k - 158;
                    int num159 = k - 159;
                    int num160 = k - 160;
                    int num161 = k - 161;
                    int num162 = k - 162;
                    int num163 = k - 163;
                    int num164 = k - 164;
                    int num165 = k - 165;
                    int num166 = k - 166;
                    int num167 = k - 167;
                    int num168 = k - 168;
                    int num169 = k - 169;
                    int num170 = k - 170;
                    int num171 = k - 171;
                    int num172 = k - 172;
                    int num173 = k - 173;
                    int num174 = k - 174;
                    int num175 = k - 175;
                    int num176 = k - 176;
                    int num177 = k - 177;
                    int num178 = k - 178;
                    int num179 = k - 179;
                    int num180 = k - 180;
                    int num181 = k - 181;
                    int num182 = k - 182;
                    int num183 = k - 183;
                    int num184 = k - 184;
                    int num185 = k - 185;
                    int num186 = k - 186;
                    int num187 = k - 187;
                    int num188 = k - 188;
                    int num189 = k - 189;
                    int num190 = k - 190;
                    int num191 = k - 191;
                    int num192 = k - 192;
                    int num193 = k - 193;
                    int num194 = k - 194;
                    int num195 = k - 195;
                    int num196 = k - 196;
                    int num197 = k - 197;
                    int num198 = k - 198;
                    int num199 = k - 199;
                    int num200 = k - 200;
                    int num201 = k - 201;
                    int num202 = k - 202;
                    int num203 = k - 203;
                    int num204 = k - 204;
                    int num205 = k - 205;
                    int num206 = k - 206;
                    int num207 = k - 207;
                    int num208 = k - 208;
                    int num209 = k - 209;
                    int num210 = k - 210;
                    int num211 = k - 211;
                    int num212 = k - 212;
                    int num213 = k - 213;
                    int num214 = k - 214;
                    int num215 = k - 215;
                    int num216 = k - 216;
                    int num217 = k - 217;
                    int num218 = k - 218;
                    int num219 = k - 219;
                    int num220 = k - 220;
                    int num221 = k - 221;
                    int num222 = k - 222;
                    int num223 = k - 223;
                    int num224 = k - 224;
                    int num225 = k - 225;
                    int num226 = k - 226;
                    int num227 = k - 227;
                    int num228 = k - 228;
                    int num229 = k - 229;
                    int num230 = k - 230;
                    int num231 = k - 231;
                    int num232 = k - 232;
                    int num233 = k - 233;
                    int num234 = k - 234;
                    int num235 = k - 235;
                    int num236 = k - 236;
                    int num237 = k - 237;
                    int num238 = k - 238;
                    int num239 = k - 239;
                    int num240 = k - 240;
                    int num241 = k - 241;
                    int num242 = k - 242;
                    int num243 = k - 243;
                    int num244 = k - 244;
                    int num245 = k - 245;
                    int num246 = k - 246;
                    int num247 = k - 247;
                    int num248 = k - 248;
                    int num249 = k - 249;
                    int num250 = k - 250;
                    int num251 = k - 251;
                    int num252 = k - 252;
                    int num253 = k - 253;
                    int num254 = k - 254;
                    int num255 = k - 255;



                    string chris = "0" + Convert.ToInt32(asc);






                    if (chris == "001")
                    {


                        textBox2.Text += Convert.ToString(num1);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "002")
                    {


                        textBox2.Text += Convert.ToString(num2);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "003")
                    {


                        textBox2.Text += Convert.ToString(num3);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }



                    if (chris == "004")
                    {


                        textBox2.Text += Convert.ToString(num4);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }


                    }



                    if (chris == "005")
                    {


                        textBox2.Text += Convert.ToString(num5);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }




                    if (chris == "006")
                    {


                        textBox2.Text += Convert.ToString(num6);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }


                    }

                    if (chris == "007")
                    {


                        textBox2.Text += Convert.ToString(num7);

                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "008")
                    {


                        textBox2.Text += Convert.ToString(num8);

                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "009")
                    {


                        textBox2.Text += Convert.ToString(num9);

                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }



                    if (chris == "010")
                    {


                        textBox2.Text += Convert.ToString(num10);

                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "011")
                    {


                        textBox2.Text += Convert.ToString(num11);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }




                    if (chris == "012")
                    {


                        textBox2.Text += Convert.ToString(num12);

                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }



                    if (chris == "013")
                    {


                        textBox2.Text += Convert.ToString(num13);

                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "014")
                    {


                        textBox2.Text += Convert.ToString(num14);

                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "015")
                    {


                        textBox2.Text += Convert.ToString(num15);

                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }

                    if (chris == "016")
                    {


                        textBox2.Text += Convert.ToString(num16);

                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "017")
                    {


                        textBox2.Text += Convert.ToString(num17);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }

                    if (chris == "018")
                    {


                        textBox2.Text += Convert.ToString(num18);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }



                    if (chris == "019")
                    {


                        textBox2.Text += Convert.ToString(num19);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }

                    if (chris == "020")
                    {


                        textBox2.Text += Convert.ToString(num20);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "021")
                    {


                        textBox2.Text += Convert.ToString(num21);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }

                    if (chris == "022")
                    {


                        textBox2.Text += Convert.ToString(num22);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }

                    if (chris == "023")
                    {


                        textBox2.Text += Convert.ToString(num23);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }

                    if (chris == "024")
                    {


                        textBox2.Text += Convert.ToString(num24);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }

                    if (chris == "025")
                    {


                        textBox2.Text += Convert.ToString(num25);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }

                    if (chris == "026")
                    {


                        textBox2.Text += Convert.ToString(num26);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "027")
                    {


                        textBox2.Text += Convert.ToString(num27);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }

                    if (chris == "028")
                    {


                        textBox2.Text += Convert.ToString(num28);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "029")
                    {


                        textBox2.Text += Convert.ToString(num29);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }

                    if (chris == "030")
                    {


                        textBox2.Text += Convert.ToString(num30);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "031")
                    {


                        textBox2.Text += Convert.ToString(num31);

                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }

                    if (chris == "032")
                    {


                        textBox2.Text += Convert.ToString(num32);

                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }

                    if (chris == "033")
                    {


                        textBox2.Text += Convert.ToString(num33);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }

                    if (chris == "034")
                    {


                        textBox2.Text += Convert.ToString(num34);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }

                    if (chris == "035")
                    {


                        textBox2.Text += Convert.ToString(num35);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }

                    if (chris == "036")
                    {


                        textBox2.Text += Convert.ToString(num36);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "037")
                    {


                        textBox2.Text += Convert.ToString(num37);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "038")
                    {


                        textBox2.Text += Convert.ToString(num38);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "039")
                    {


                        textBox2.Text += Convert.ToString(num39);

                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }

                    if (chris == "040")
                    {


                        textBox2.Text += Convert.ToString(num40);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "041")
                    {


                        textBox2.Text += Convert.ToString(num41);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }

                    if (chris == "042")
                    {


                        textBox2.Text += Convert.ToString(num42);

                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "043")
                    {


                        textBox2.Text += Convert.ToString(num43);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "044")
                    {


                        textBox2.Text += Convert.ToString(num44);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "045")
                    {


                        textBox2.Text += Convert.ToString(num45);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "046")
                    {


                        textBox2.Text += Convert.ToString(num46);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "047")
                    {


                        textBox2.Text += Convert.ToString(num47);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "048")
                    {


                        textBox2.Text += Convert.ToString(num48);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "049")
                    {


                        textBox2.Text += Convert.ToString(num49);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }

                    if (chris == "050")
                    {


                        textBox2.Text += Convert.ToString(num50);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "051")
                    {


                        textBox2.Text += Convert.ToString(num51);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "052")
                    {


                        textBox2.Text += Convert.ToString(num52);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }



                    if (chris == "053")
                    {


                        textBox2.Text += Convert.ToString(num53);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }



                    if (chris == "054")
                    {


                        textBox2.Text += Convert.ToString(num54);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }




                    if (chris == "055")
                    {


                        textBox2.Text += Convert.ToString(num55);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "056")
                    {


                        textBox2.Text += Convert.ToString(num56);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }

                    if (chris == "057")
                    {


                        textBox2.Text += Convert.ToString(num57);



                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }

                    if (chris == "058")
                    {


                        textBox2.Text += Convert.ToString(num58);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "059")
                    {


                        textBox2.Text += Convert.ToString(num59);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "060")
                    {


                        textBox2.Text += Convert.ToString(num60);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }



                    }


                    if (chris == "061")
                    {


                        textBox2.Text += Convert.ToString(num61);

                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }


                    }


                    if (chris == "062")
                    {


                        textBox2.Text += Convert.ToString(num62);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "063")
                    {


                        textBox2.Text += Convert.ToString(num63);

                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }


                    }


                    if (chris == "064")
                    {


                        textBox2.Text += Convert.ToString(num64);

                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "065")
                    {


                        textBox2.Text += Convert.ToString(num65);

                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "066")
                    {


                        textBox2.Text += Convert.ToString(num66);

                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }

                    if (chris == "067")
                    {


                        textBox2.Text += Convert.ToString(num67);

                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }


                    }


                    if (chris == "068")
                    {


                        textBox2.Text += Convert.ToString(num68);

                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }


                    }


                    if (chris == "069")
                    {


                        textBox2.Text += Convert.ToString(num69);

                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }



                    if (chris == "070")
                    {


                        textBox2.Text += Convert.ToString(num70);

                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }



                    if (chris == "071")
                    {


                        textBox2.Text += Convert.ToString(num71);

                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }



                    if (chris == "072")
                    {


                        textBox2.Text += Convert.ToString(num72);

                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }



                    if (chris == "073")
                    {


                        textBox2.Text += Convert.ToString(num73);

                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "074")
                    {


                        textBox2.Text += Convert.ToString(num74);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "075")
                    {


                        textBox2.Text += Convert.ToString(num75);

                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }

                    if (chris == "076")
                    {


                        textBox2.Text += Convert.ToString(num76);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }


                    }

                    if (chris == "077")
                    {


                        textBox2.Text += Convert.ToString(num77);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }


                    }


                    if (chris == "078")
                    {


                        textBox2.Text += Convert.ToString(num78);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "079")
                    {


                        textBox2.Text += Convert.ToString(num79);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "080")
                    {


                        textBox2.Text += Convert.ToString(num80);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "081")
                    {


                        textBox2.Text += Convert.ToString(num81);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "082")
                    {


                        textBox2.Text += Convert.ToString(num82);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "083")
                    {


                        textBox2.Text += Convert.ToString(num83);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "084")
                    {


                        textBox2.Text += Convert.ToString(num84);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "085")
                    {


                        textBox2.Text += Convert.ToString(num85);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "086")
                    {


                        textBox2.Text += Convert.ToString(num86);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "087")
                    {


                        textBox2.Text += Convert.ToString(num87);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "088")
                    {


                        textBox2.Text += Convert.ToString(num88);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "089")
                    {


                        textBox2.Text += Convert.ToString(num89);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "090")
                    {


                        textBox2.Text += Convert.ToString(num90);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "091")
                    {


                        textBox2.Text += Convert.ToString(num91);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "092")
                    {


                        textBox2.Text += Convert.ToString(num92);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "093")
                    {


                        textBox2.Text += Convert.ToString(num93);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "094")
                    {


                        textBox2.Text += Convert.ToString(num94);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "095")
                    {


                        textBox2.Text += Convert.ToString(num95);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "096")
                    {


                        textBox2.Text += Convert.ToString(num96);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "097")
                    {


                        textBox2.Text += Convert.ToString(num97);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }




                    if (chris == "098")
                    {


                        textBox2.Text += Convert.ToString(num97);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "099")
                    {



                        textBox2.Text += Convert.ToString(num99);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "100")
                    {


                        textBox2.Text += Convert.ToString(num100);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "101")
                    {


                        textBox2.Text += Convert.ToString(num101);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "102")
                    {


                        textBox2.Text += Convert.ToString(num102);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "103")
                    {


                        textBox2.Text += Convert.ToString(num103);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "104")
                    {


                        textBox2.Text += Convert.ToString(num104);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "105")
                    {


                        textBox2.Text += Convert.ToString(num105);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "106")
                    {


                        textBox2.Text += Convert.ToString(num106);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "107")
                    {


                        textBox2.Text += Convert.ToString(num107);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "108")
                    {


                        textBox2.Text += Convert.ToString(num108);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "109")
                    {


                        textBox2.Text += Convert.ToString(num109);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "110")
                    {


                        textBox2.Text += Convert.ToString(num110);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "111")
                    {


                        textBox2.Text += Convert.ToString(num111);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "112")
                    {


                        textBox2.Text += Convert.ToString(num112);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }



                    if (chris == "113")
                    {


                        textBox2.Text += Convert.ToString(num113);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "114")
                    {


                        textBox2.Text += Convert.ToString(num114);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "115")
                    {


                        textBox2.Text += Convert.ToString(num115);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "116")
                    {


                        textBox2.Text += Convert.ToString(num116);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }



                    if (chris == "117")
                    {


                        textBox2.Text += Convert.ToString(num117);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }



                    if (chris == "118")
                    {


                        textBox2.Text += Convert.ToString(num118);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }



                    if (chris == "119")
                    {


                        textBox2.Text += Convert.ToString(num119);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "120")
                    {


                        textBox2.Text += Convert.ToString(num120);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }



                    if (chris == "121")
                    {


                        textBox2.Text += Convert.ToString(num121);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "122")
                    {


                        textBox2.Text += Convert.ToString(num122);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "123")
                    {


                        textBox2.Text += Convert.ToString(num123);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "124")
                    {


                        textBox2.Text += Convert.ToString(num124);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "125")
                    {


                        textBox2.Text += Convert.ToString(num125);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "126")
                    {


                        textBox2.Text += Convert.ToString(num126);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "127")
                    {


                        textBox2.Text += Convert.ToString(num127);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "128")
                    {


                        textBox2.Text += Convert.ToString(num128);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "129")
                    {


                        textBox2.Text += Convert.ToString(num129);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "130")
                    {


                        textBox2.Text += Convert.ToString(num130);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "131")
                    {


                        textBox2.Text += Convert.ToString(num131);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "132")
                    {


                        textBox2.Text += Convert.ToString(num132);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "133")
                    {


                        textBox2.Text += Convert.ToString(num133);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "134")
                    {


                        textBox2.Text += Convert.ToString(num134);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "135")
                    {


                        textBox2.Text += Convert.ToString(num135);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "136")
                    {


                        textBox2.Text += Convert.ToString(num136);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "137")
                    {


                        textBox2.Text += Convert.ToString(num137);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "138")
                    {


                        textBox2.Text += Convert.ToString(num138);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "139")
                    {


                        textBox2.Text += Convert.ToString(num139);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "140")
                    {


                        textBox2.Text += Convert.ToString(num140);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "141")
                    {


                        textBox2.Text += Convert.ToString(num141);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }

                    if (chris == "142")
                    {


                        textBox2.Text += Convert.ToString(num142);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "143")
                    {


                        textBox2.Text += Convert.ToString(num143);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "144")
                    {


                        textBox2.Text += Convert.ToString(num144);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "145")
                    {


                        textBox2.Text += Convert.ToString(num145);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "146")
                    {


                        textBox2.Text += Convert.ToString(num146);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "147")
                    {


                        textBox2.Text += Convert.ToString(num147);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "148")
                    {


                        textBox2.Text += Convert.ToString(num148);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "149")
                    {


                        textBox2.Text += Convert.ToString(num149);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "150")
                    {


                        textBox2.Text += Convert.ToString(num150);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "151")
                    {


                        textBox2.Text += Convert.ToString(num151);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "152")
                    {


                        textBox2.Text += Convert.ToString(num152);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "153")
                    {


                        textBox2.Text += Convert.ToString(num153);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "154")
                    {


                        textBox2.Text += Convert.ToString(num154);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "155")
                    {


                        textBox2.Text += Convert.ToString(num155);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "156")
                    {


                        textBox2.Text += Convert.ToString(num156);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "157")
                    {


                        textBox2.Text += Convert.ToString(num157);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "158")
                    {


                        textBox2.Text += Convert.ToString(num158);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "159")
                    {


                        textBox2.Text += Convert.ToString(num159);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "160")
                    {


                        textBox2.Text += Convert.ToString(num160);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "161")
                    {


                        textBox2.Text += Convert.ToString(num161);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "162")
                    {


                        textBox2.Text += Convert.ToString(num162);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "163")
                    {


                        textBox2.Text += Convert.ToString(num163);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "164")
                    {


                        textBox2.Text += Convert.ToString(num164);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "165")
                    {


                        textBox2.Text += Convert.ToString(num165);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "166")
                    {


                        textBox2.Text += Convert.ToString(num166);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "167")
                    {


                        textBox2.Text += Convert.ToString(num167);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "168")
                    {


                        textBox2.Text += Convert.ToString(num168);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "169")
                    {


                        textBox2.Text += Convert.ToString(num169);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "170")
                    {


                        textBox2.Text += Convert.ToString(num170);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "171")
                    {


                        textBox2.Text += Convert.ToString(num171);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "172")
                    {


                        textBox2.Text += Convert.ToString(num172);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "173")
                    {


                        textBox2.Text += Convert.ToString(num173);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "174")
                    {


                        textBox2.Text += Convert.ToString(num174);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "175")
                    {


                        textBox2.Text += Convert.ToString(num175);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "176")
                    {


                        textBox2.Text += Convert.ToString(num176);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "177")
                    {


                        textBox2.Text += Convert.ToString(num177);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "178")
                    {


                        textBox2.Text += Convert.ToString(num178);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "179")
                    {


                        textBox2.Text += Convert.ToString(num179);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "180")
                    {


                        textBox2.Text += Convert.ToString(num180);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "181")
                    {


                        textBox2.Text += Convert.ToString(num181);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "182")
                    {


                        textBox2.Text += Convert.ToString(num182);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "183")
                    {


                        textBox2.Text += Convert.ToString(num183);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "184")
                    {


                        textBox2.Text += Convert.ToString(num184);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "185")
                    {


                        textBox2.Text += Convert.ToString(num185);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "186")
                    {


                        textBox2.Text += Convert.ToString(num186);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "187")
                    {


                        textBox2.Text += Convert.ToString(num187);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "188")
                    {


                        textBox2.Text += Convert.ToString(num188);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "189")
                    {


                        textBox2.Text += Convert.ToString(num189);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "190")
                    {


                        textBox2.Text += Convert.ToString(num190);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "191")
                    {


                        textBox2.Text += Convert.ToString(num191);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "192")
                    {


                        textBox2.Text += Convert.ToString(num192);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "193")
                    {


                        textBox2.Text += Convert.ToString(num193);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "194")
                    {


                        textBox2.Text += Convert.ToString(num194);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "195")
                    {


                        textBox2.Text += Convert.ToString(num195);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "196")
                    {


                        textBox2.Text += Convert.ToString(num196);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "197")
                    {


                        textBox2.Text += Convert.ToString(num197);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "198")
                    {


                        textBox2.Text += Convert.ToString(num198);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "199")
                    {


                        textBox2.Text += Convert.ToString(num199);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "200")
                    {


                        textBox2.Text += Convert.ToString(num200);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "201")
                    {


                        textBox2.Text += Convert.ToString(num201);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }



                    if (chris == "202")
                    {


                        textBox2.Text += Convert.ToString(num202);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }



                    if (chris == "203")
                    {


                        textBox2.Text += Convert.ToString(num203);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "204")
                    {


                        textBox2.Text += Convert.ToString(num204);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "205")
                    {


                        textBox2.Text += Convert.ToString(num205);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "206")
                    {


                        textBox2.Text += Convert.ToString(num206);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "207")
                    {


                        textBox2.Text += Convert.ToString(num207);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "208")
                    {


                        textBox2.Text += Convert.ToString(num208);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "209")
                    {


                        textBox2.Text += Convert.ToString(num209);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "210")
                    {


                        textBox2.Text += Convert.ToString(num210);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }



                    if (chris == "211")
                    {


                        textBox2.Text += Convert.ToString(num211);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "212")
                    {


                        textBox2.Text += Convert.ToString(num212);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "213")
                    {


                        textBox2.Text += Convert.ToString(num213);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "214")
                    {


                        textBox2.Text += Convert.ToString(num214);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "215")
                    {


                        textBox2.Text += Convert.ToString(num215);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "216")
                    {


                        textBox2.Text += Convert.ToString(num216);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "217")
                    {


                        textBox2.Text += Convert.ToString(num217);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "218")
                    {


                        textBox2.Text += Convert.ToString(num218);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "219")
                    {


                        textBox2.Text += Convert.ToString(num219);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "220")
                    {


                        textBox2.Text += Convert.ToString(num220);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "221")
                    {


                        textBox2.Text += Convert.ToString(num221);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "222")
                    {


                        textBox2.Text += Convert.ToString(num222);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "223")
                    {


                        textBox2.Text += Convert.ToString(num223);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "224")
                    {


                        textBox2.Text += Convert.ToString(num224);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "225")
                    {


                        textBox2.Text += Convert.ToString(num225);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "226")
                    {


                        textBox2.Text += Convert.ToString(num226);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "227")
                    {


                        textBox2.Text += Convert.ToString(num227);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "228")
                    {


                        textBox2.Text += Convert.ToString(num228);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "229")
                    {


                        textBox2.Text += Convert.ToString(num229);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "230")
                    {


                        textBox2.Text += Convert.ToString(num230);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "231")
                    {


                        textBox2.Text += Convert.ToString(num231);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "232")
                    {


                        textBox2.Text += Convert.ToString(num232);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "233")
                    {


                        textBox2.Text += Convert.ToString(num233);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }



                    if (chris == "234")
                    {


                        textBox2.Text += Convert.ToString(num234);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }



                    if (chris == "235")
                    {


                        textBox2.Text += Convert.ToString(num235);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "236")
                    {


                        textBox2.Text += Convert.ToString(num236);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "237")
                    {


                        textBox2.Text += Convert.ToString(num237);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "238")
                    {


                        textBox2.Text += Convert.ToString(num238);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "239")
                    {


                        textBox2.Text += Convert.ToString(num239);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "240")
                    {


                        textBox2.Text += Convert.ToString(num240);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "241")
                    {


                        textBox2.Text += Convert.ToString(num241);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "242")
                    {


                        textBox2.Text += Convert.ToString(num242);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "243")
                    {


                        textBox2.Text += Convert.ToString(num243);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "244")
                    {


                        textBox2.Text += Convert.ToString(num244);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "245")
                    {


                        textBox2.Text += Convert.ToString(num245);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "246")
                    {


                        textBox2.Text += Convert.ToString(num246);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "247")
                    {


                        textBox2.Text += Convert.ToString(num247);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "248")
                    {


                        textBox2.Text += Convert.ToString(num248);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "249")
                    {


                        textBox2.Text += Convert.ToString(num249);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "250")
                    {


                        textBox2.Text += Convert.ToString(num250);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "251")
                    {


                        textBox2.Text += Convert.ToString(num251);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "252")
                    {


                        textBox2.Text += Convert.ToString(num252);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "253")
                    {


                        textBox2.Text += Convert.ToString(num253);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "254")
                    {


                        textBox2.Text += Convert.ToString(num254);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "255")
                    {


                        textBox2.Text += Convert.ToString(num255);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }



                }
                else
                {
                    string chris = "";
                    chris += Convert.ToInt32(asc);






                    Random rnd = new Random();



                    //int k = rnd.Next(260, 999);

                    int k = Convert.ToInt16(textBox5.Text);


                    int num1 = k - 1;
                    int num2 = k - 2;
                    int num3 = k - 3;
                    int num4 = k - 4;
                    int num5 = k - 5;
                    int num6 = k - 6;
                    int num7 = k - 7;
                    int num8 = k - 8;
                    int num9 = k - 9;
                    int num10 = k - 10;
                    int num11 = k - 11;
                    int num12 = k - 12;
                    int num13 = k - 13;
                    int num14 = k - 14;
                    int num15 = k - 15;
                    int num16 = k - 16;
                    int num17 = k - 17;
                    int num18 = k - 18;
                    int num19 = k - 19;
                    int num20 = k - 20;
                    int num21 = k - 21;
                    int num22 = k - 22;
                    int num23 = k - 23;
                    int num24 = k - 24;
                    int num25 = k - 25;
                    int num26 = k - 26;
                    int num27 = k - 27;
                    int num28 = k - 28;
                    int num29 = k - 29;
                    int num30 = k - 30;
                    int num31 = k - 31;
                    int num32 = k - 32;
                    int num33 = k - 33;
                    int num34 = k - 34;
                    int num35 = k - 35;
                    int num36 = k - 36;
                    int num37 = k - 37;
                    int num38 = k - 38;
                    int num39 = k - 39;
                    int num40 = k - 40;
                    int num41 = k - 41;
                    int num42 = k - 42;
                    int num43 = k - 43;
                    int num44 = k - 44;
                    int num45 = k - 45;
                    int num46 = k - 46;
                    int num47 = k - 47;
                    int num48 = k - 48;
                    int num49 = k - 49;
                    int num50 = k - 50;
                    int num51 = k - 51;
                    int num52 = k - 52;
                    int num53 = k - 53;
                    int num54 = k - 54;
                    int num55 = k - 55;
                    int num56 = k - 56;
                    int num57 = k - 57;
                    int num58 = k - 58;
                    int num59 = k - 59;
                    int num60 = k - 60;
                    int num61 = k - 61;
                    int num62 = k - 62;
                    int num63 = k - 63;
                    int num64 = k - 64;
                    int num65 = k - 65;
                    int num66 = k - 66;
                    int num67 = k - 67;
                    int num68 = k - 68;
                    int num69 = k - 69;
                    int num70 = k - 70;
                    int num71 = k - 71;
                    int num72 = k - 72;
                    int num73 = k - 73;
                    int num74 = k - 74;
                    int num75 = k - 75;
                    int num76 = k - 76;
                    int num77 = k - 77;
                    int num78 = k - 78;
                    int num79 = k - 79;
                    int num80 = k - 80;
                    int num81 = k - 81;
                    int num82 = k - 82;
                    int num83 = k - 83;
                    int num84 = k - 84;
                    int num85 = k - 85;
                    int num86 = k - 86;
                    int num87 = k - 87;
                    int num88 = k - 88;
                    int num89 = k - 89;
                    int num90 = k - 90;
                    int num91 = k - 91;
                    int num92 = k - 92;
                    int num93 = k - 93;
                    int num94 = k - 94;
                    int num95 = k - 95;
                    int num96 = k - 96;
                    int num97 = k - 97;
                    int num98 = k - 98;
                    int num99 = k - 99;
                    int num100 = k - 100;
                    int num101 = k - 101;
                    int num102 = k - 102;
                    int num103 = k - 103;
                    int num104 = k - 104;
                    int num105 = k - 105;
                    int num106 = k - 106;
                    int num107 = k - 107;
                    int num108 = k - 108;
                    int num109 = k - 109;
                    int num110 = k - 110;
                    int num111 = k - 111;
                    int num112 = k - 112;
                    int num113 = k - 113;
                    int num114 = k - 114;
                    int num115 = k - 115;
                    int num116 = k - 116;
                    int num117 = k - 117;
                    int num118 = k - 118;
                    int num119 = k - 119;
                    int num120 = k - 120;
                    int num121 = k - 121;
                    int num122 = k - 122;
                    int num123 = k - 123;
                    int num124 = k - 124;
                    int num125 = k - 125;
                    int num126 = k - 126;
                    int num127 = k - 127;
                    int num128 = k - 128;
                    int num129 = k - 129;
                    int num130 = k - 130;
                    int num131 = k - 131;
                    int num132 = k - 132;
                    int num133 = k - 133;
                    int num134 = k - 134;
                    int num135 = k - 135;
                    int num136 = k - 136;
                    int num137 = k - 137;
                    int num138 = k - 138;
                    int num139 = k - 139;
                    int num140 = k - 140;
                    int num141 = k - 141;
                    int num142 = k - 142;
                    int num143 = k - 143;
                    int num144 = k - 144;
                    int num145 = k - 145;
                    int num146 = k - 146;
                    int num147 = k - 147;
                    int num148 = k - 148;
                    int num149 = k - 149;
                    int num150 = k - 150;
                    int num151 = k - 151;
                    int num152 = k - 152;
                    int num153 = k - 153;
                    int num154 = k - 154;
                    int num155 = k - 155;
                    int num156 = k - 156;
                    int num157 = k - 157;
                    int num158 = k - 158;
                    int num159 = k - 159;
                    int num160 = k - 160;
                    int num161 = k - 161;
                    int num162 = k - 162;
                    int num163 = k - 163;
                    int num164 = k - 164;
                    int num165 = k - 165;
                    int num166 = k - 166;
                    int num167 = k - 167;
                    int num168 = k - 168;
                    int num169 = k - 169;
                    int num170 = k - 170;
                    int num171 = k - 171;
                    int num172 = k - 172;
                    int num173 = k - 173;
                    int num174 = k - 174;
                    int num175 = k - 175;
                    int num176 = k - 176;
                    int num177 = k - 177;
                    int num178 = k - 178;
                    int num179 = k - 179;
                    int num180 = k - 180;
                    int num181 = k - 181;
                    int num182 = k - 182;
                    int num183 = k - 183;
                    int num184 = k - 184;
                    int num185 = k - 185;
                    int num186 = k - 186;
                    int num187 = k - 187;
                    int num188 = k - 188;
                    int num189 = k - 189;
                    int num190 = k - 190;
                    int num191 = k - 191;
                    int num192 = k - 192;
                    int num193 = k - 193;
                    int num194 = k - 194;
                    int num195 = k - 195;
                    int num196 = k - 196;
                    int num197 = k - 197;
                    int num198 = k - 198;
                    int num199 = k - 199;
                    int num200 = k - 200;
                    int num201 = k - 201;
                    int num202 = k - 202;
                    int num203 = k - 203;
                    int num204 = k - 204;
                    int num205 = k - 205;
                    int num206 = k - 206;
                    int num207 = k - 207;
                    int num208 = k - 208;
                    int num209 = k - 209;
                    int num210 = k - 210;
                    int num211 = k - 211;
                    int num212 = k - 212;
                    int num213 = k - 213;
                    int num214 = k - 214;
                    int num215 = k - 215;
                    int num216 = k - 216;
                    int num217 = k - 217;
                    int num218 = k - 218;
                    int num219 = k - 219;
                    int num220 = k - 220;
                    int num221 = k - 221;
                    int num222 = k - 222;
                    int num223 = k - 223;
                    int num224 = k - 224;
                    int num225 = k - 225;
                    int num226 = k - 226;
                    int num227 = k - 227;
                    int num228 = k - 228;
                    int num229 = k - 229;
                    int num230 = k - 230;
                    int num231 = k - 231;
                    int num232 = k - 232;
                    int num233 = k - 233;
                    int num234 = k - 234;
                    int num235 = k - 235;
                    int num236 = k - 236;
                    int num237 = k - 237;
                    int num238 = k - 238;
                    int num239 = k - 239;
                    int num240 = k - 240;
                    int num241 = k - 241;
                    int num242 = k - 242;
                    int num243 = k - 243;
                    int num244 = k - 244;
                    int num245 = k - 245;
                    int num246 = k - 246;
                    int num247 = k - 247;
                    int num248 = k - 248;
                    int num249 = k - 249;
                    int num250 = k - 250;
                    int num251 = k - 251;
                    int num252 = k - 252;
                    int num253 = k - 253;
                    int num254 = k - 254;
                    int num255 = k - 255;




                    if (chris == "001")
                    {


                        textBox2.Text += Convert.ToString(num1);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "002")
                    {


                        textBox2.Text += Convert.ToString(num2);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "003")
                    {


                        textBox2.Text += Convert.ToString(num3);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }



                    if (chris == "004")
                    {


                        textBox2.Text += Convert.ToString(num4);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }


                    }



                    if (chris == "005")
                    {


                        textBox2.Text += Convert.ToString(num5);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }




                    if (chris == "006")
                    {


                        textBox2.Text += Convert.ToString(num6);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }


                    }

                    if (chris == "007")
                    {


                        textBox2.Text += Convert.ToString(num7);

                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "008")
                    {


                        textBox2.Text += Convert.ToString(num8);

                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "009")
                    {


                        textBox2.Text += Convert.ToString(num9);

                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }



                    if (chris == "010")
                    {


                        textBox2.Text += Convert.ToString(num10);

                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "011")
                    {


                        textBox2.Text += Convert.ToString(num11);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }




                    if (chris == "012")
                    {


                        textBox2.Text += Convert.ToString(num12);

                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }



                    if (chris == "013")
                    {


                        textBox2.Text += Convert.ToString(num13);

                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "014")
                    {


                        textBox2.Text += Convert.ToString(num14);

                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "015")
                    {


                        textBox2.Text += Convert.ToString(num15);

                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }

                    if (chris == "016")
                    {


                        textBox2.Text += Convert.ToString(num16);

                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "017")
                    {


                        textBox2.Text += Convert.ToString(num17);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }

                    if (chris == "018")
                    {


                        textBox2.Text += Convert.ToString(num18);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }



                    if (chris == "019")
                    {


                        textBox2.Text += Convert.ToString(num19);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }

                    if (chris == "020")
                    {


                        textBox2.Text += Convert.ToString(num20);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "021")
                    {


                        textBox2.Text += Convert.ToString(num21);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }

                    if (chris == "022")
                    {


                        textBox2.Text += Convert.ToString(num22);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }

                    if (chris == "023")
                    {


                        textBox2.Text += Convert.ToString(num23);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }

                    if (chris == "024")
                    {


                        textBox2.Text += Convert.ToString(num24);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }

                    if (chris == "025")
                    {


                        textBox2.Text += Convert.ToString(num25);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }

                    if (chris == "026")
                    {


                        textBox2.Text += Convert.ToString(num26);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "027")
                    {


                        textBox2.Text += Convert.ToString(num27);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }

                    if (chris == "028")
                    {


                        textBox2.Text += Convert.ToString(num28);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "029")
                    {


                        textBox2.Text += Convert.ToString(num29);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }

                    if (chris == "030")
                    {


                        textBox2.Text += Convert.ToString(num30);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "031")
                    {


                        textBox2.Text += Convert.ToString(num31);

                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }

                    if (chris == "032")
                    {


                        textBox2.Text += Convert.ToString(num32);

                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }

                    if (chris == "033")
                    {


                        textBox2.Text += Convert.ToString(num33);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }

                    if (chris == "034")
                    {


                        textBox2.Text += Convert.ToString(num34);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }

                    if (chris == "035")
                    {


                        textBox2.Text += Convert.ToString(num35);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }

                    if (chris == "036")
                    {


                        textBox2.Text += Convert.ToString(num36);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "037")
                    {


                        textBox2.Text += Convert.ToString(num37);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "038")
                    {


                        textBox2.Text += Convert.ToString(num38);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "039")
                    {


                        textBox2.Text += Convert.ToString(num39);

                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }

                    if (chris == "040")
                    {


                        textBox2.Text += Convert.ToString(num40);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "041")
                    {


                        textBox2.Text += Convert.ToString(num41);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }

                    if (chris == "042")
                    {


                        textBox2.Text += Convert.ToString(num42);

                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "043")
                    {


                        textBox2.Text += Convert.ToString(num43);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "044")
                    {


                        textBox2.Text += Convert.ToString(num44);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "045")
                    {


                        textBox2.Text += Convert.ToString(num45);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "046")
                    {


                        textBox2.Text += Convert.ToString(num46);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "047")
                    {


                        textBox2.Text += Convert.ToString(num47);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "048")
                    {


                        textBox2.Text += Convert.ToString(num48);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "049")
                    {


                        textBox2.Text += Convert.ToString(num49);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }

                    if (chris == "050")
                    {


                        textBox2.Text += Convert.ToString(num50);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "051")
                    {


                        textBox2.Text += Convert.ToString(num51);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "052")
                    {


                        textBox2.Text += Convert.ToString(num52);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }



                    if (chris == "053")
                    {


                        textBox2.Text += Convert.ToString(num53);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }



                    if (chris == "054")
                    {


                        textBox2.Text += Convert.ToString(num54);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }




                    if (chris == "055")
                    {


                        textBox2.Text += Convert.ToString(num55);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "056")
                    {


                        textBox2.Text += Convert.ToString(num56);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }

                    if (chris == "057")
                    {


                        textBox2.Text += Convert.ToString(num57);



                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }

                    if (chris == "058")
                    {


                        textBox2.Text += Convert.ToString(num58);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "059")
                    {


                        textBox2.Text += Convert.ToString(num59);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "060")
                    {


                        textBox2.Text += Convert.ToString(num60);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }



                    }


                    if (chris == "061")
                    {


                        textBox2.Text += Convert.ToString(num61);

                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }


                    }


                    if (chris == "062")
                    {


                        textBox2.Text += Convert.ToString(num62);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "063")
                    {


                        textBox2.Text += Convert.ToString(num63);

                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }


                    }


                    if (chris == "064")
                    {


                        textBox2.Text += Convert.ToString(num64);

                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "065")
                    {


                        textBox2.Text += Convert.ToString(num65);

                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "066")
                    {


                        textBox2.Text += Convert.ToString(num66);

                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }

                    if (chris == "067")
                    {


                        textBox2.Text += Convert.ToString(num67);

                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }


                    }


                    if (chris == "068")
                    {


                        textBox2.Text += Convert.ToString(num68);

                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }


                    }


                    if (chris == "069")
                    {


                        textBox2.Text += Convert.ToString(num69);

                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }



                    if (chris == "070")
                    {


                        textBox2.Text += Convert.ToString(num70);

                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }



                    if (chris == "071")
                    {


                        textBox2.Text += Convert.ToString(num71);

                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }



                    if (chris == "072")
                    {


                        textBox2.Text += Convert.ToString(num72);

                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }



                    if (chris == "073")
                    {


                        textBox2.Text += Convert.ToString(num73);

                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "074")
                    {


                        textBox2.Text += Convert.ToString(num74);


                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "075")
                    {


                        textBox2.Text += Convert.ToString(num75);

                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }

                    if (chris == "076")
                    {


                        textBox2.Text += Convert.ToString(num76);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }


                    }

                    if (chris == "077")
                    {


                        textBox2.Text += Convert.ToString(num77);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }


                    }


                    if (chris == "078")
                    {


                        textBox2.Text += Convert.ToString(num78);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "079")
                    {


                        textBox2.Text += Convert.ToString(num79);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "080")
                    {


                        textBox2.Text += Convert.ToString(num80);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "081")
                    {


                        textBox2.Text += Convert.ToString(num81);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "082")
                    {


                        textBox2.Text += Convert.ToString(num82);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "083")
                    {


                        textBox2.Text += Convert.ToString(num83);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "084")
                    {


                        textBox2.Text += Convert.ToString(num84);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "085")
                    {


                        textBox2.Text += Convert.ToString(num85);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "086")
                    {


                        textBox2.Text += Convert.ToString(num86);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "087")
                    {


                        textBox2.Text += Convert.ToString(num87);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "088")
                    {


                        textBox2.Text += Convert.ToString(num88);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "089")
                    {


                        textBox2.Text += Convert.ToString(num89);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "090")
                    {


                        textBox2.Text += Convert.ToString(num90);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "091")
                    {


                        textBox2.Text += Convert.ToString(num91);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "092")
                    {


                        textBox2.Text += Convert.ToString(num92);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "093")
                    {


                        textBox2.Text += Convert.ToString(num93);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "094")
                    {


                        textBox2.Text += Convert.ToString(num94);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "095")
                    {


                        textBox2.Text += Convert.ToString(num95);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "096")
                    {


                        textBox2.Text += Convert.ToString(num96);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "097")
                    {


                        textBox2.Text += Convert.ToString(num97);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }




                    if (chris == "098")
                    {


                        textBox2.Text += Convert.ToString(num97);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "099")
                    {



                        textBox2.Text += Convert.ToString(num99);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "100")
                    {


                        textBox2.Text += Convert.ToString(num100);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "101")
                    {


                        textBox2.Text += Convert.ToString(num101);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "102")
                    {


                        textBox2.Text += Convert.ToString(num102);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "103")
                    {


                        textBox2.Text += Convert.ToString(num103);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "104")
                    {


                        textBox2.Text += Convert.ToString(num104);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "105")
                    {


                        textBox2.Text += Convert.ToString(num105);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "106")
                    {


                        textBox2.Text += Convert.ToString(num106);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "107")
                    {


                        textBox2.Text += Convert.ToString(num107);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "108")
                    {


                        textBox2.Text += Convert.ToString(num108);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "109")
                    {


                        textBox2.Text += Convert.ToString(num109);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "110")
                    {


                        textBox2.Text += Convert.ToString(num110);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "111")
                    {


                        textBox2.Text += Convert.ToString(num111);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "112")
                    {


                        textBox2.Text += Convert.ToString(num112);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }



                    if (chris == "113")
                    {


                        textBox2.Text += Convert.ToString(num113);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "114")
                    {


                        textBox2.Text += Convert.ToString(num114);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "115")
                    {


                        textBox2.Text += Convert.ToString(num115);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "116")
                    {


                        textBox2.Text += Convert.ToString(num116);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }



                    if (chris == "117")
                    {


                        textBox2.Text += Convert.ToString(num117);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }



                    if (chris == "118")
                    {


                        textBox2.Text += Convert.ToString(num118);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }



                    if (chris == "119")
                    {


                        textBox2.Text += Convert.ToString(num119);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "120")
                    {


                        textBox2.Text += Convert.ToString(num120);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }



                    if (chris == "121")
                    {


                        textBox2.Text += Convert.ToString(num121);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "122")
                    {


                        textBox2.Text += Convert.ToString(num122);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "123")
                    {


                        textBox2.Text += Convert.ToString(num123);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "124")
                    {


                        textBox2.Text += Convert.ToString(num124);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "125")
                    {


                        textBox2.Text += Convert.ToString(num125);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "126")
                    {


                        textBox2.Text += Convert.ToString(num126);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "127")
                    {


                        textBox2.Text += Convert.ToString(num127);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "128")
                    {


                        textBox2.Text += Convert.ToString(num128);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "129")
                    {


                        textBox2.Text += Convert.ToString(num129);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "130")
                    {


                        textBox2.Text += Convert.ToString(num130);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "131")
                    {


                        textBox2.Text += Convert.ToString(num131);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "132")
                    {


                        textBox2.Text += Convert.ToString(num132);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "133")
                    {


                        textBox2.Text += Convert.ToString(num133);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "134")
                    {


                        textBox2.Text += Convert.ToString(num134);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "135")
                    {


                        textBox2.Text += Convert.ToString(num135);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "136")
                    {


                        textBox2.Text += Convert.ToString(num136);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "137")
                    {


                        textBox2.Text += Convert.ToString(num137);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "138")
                    {


                        textBox2.Text += Convert.ToString(num138);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "139")
                    {


                        textBox2.Text += Convert.ToString(num139);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "140")
                    {


                        textBox2.Text += Convert.ToString(num140);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "141")
                    {


                        textBox2.Text += Convert.ToString(num141);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }

                    if (chris == "142")
                    {


                        textBox2.Text += Convert.ToString(num142);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "143")
                    {


                        textBox2.Text += Convert.ToString(num143);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "144")
                    {


                        textBox2.Text += Convert.ToString(num144);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "145")
                    {


                        textBox2.Text += Convert.ToString(num145);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "146")
                    {


                        textBox2.Text += Convert.ToString(num146);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "147")
                    {


                        textBox2.Text += Convert.ToString(num147);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "148")
                    {


                        textBox2.Text += Convert.ToString(num148);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "149")
                    {


                        textBox2.Text += Convert.ToString(num149);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "150")
                    {


                        textBox2.Text += Convert.ToString(num150);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "151")
                    {


                        textBox2.Text += Convert.ToString(num151);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "152")
                    {


                        textBox2.Text += Convert.ToString(num152);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }

                    }


                    if (chris == "153")
                    {


                        textBox2.Text += Convert.ToString(num153);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "154")
                    {


                        textBox2.Text += Convert.ToString(num154);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "155")
                    {


                        textBox2.Text += Convert.ToString(num155);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "156")
                    {


                        textBox2.Text += Convert.ToString(num156);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "157")
                    {


                        textBox2.Text += Convert.ToString(num157);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "158")
                    {


                        textBox2.Text += Convert.ToString(num158);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "159")
                    {


                        textBox2.Text += Convert.ToString(num159);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "160")
                    {


                        textBox2.Text += Convert.ToString(num160);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "161")
                    {


                        textBox2.Text += Convert.ToString(num161);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "162")
                    {


                        textBox2.Text += Convert.ToString(num162);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "163")
                    {


                        textBox2.Text += Convert.ToString(num163);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "164")
                    {


                        textBox2.Text += Convert.ToString(num164);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "165")
                    {


                        textBox2.Text += Convert.ToString(num165);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "166")
                    {


                        textBox2.Text += Convert.ToString(num166);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "167")
                    {


                        textBox2.Text += Convert.ToString(num167);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "168")
                    {


                        textBox2.Text += Convert.ToString(num168);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "169")
                    {


                        textBox2.Text += Convert.ToString(num169);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "170")
                    {


                        textBox2.Text += Convert.ToString(num170);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "171")
                    {


                        textBox2.Text += Convert.ToString(num171);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "172")
                    {


                        textBox2.Text += Convert.ToString(num172);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "173")
                    {


                        textBox2.Text += Convert.ToString(num173);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "174")
                    {


                        textBox2.Text += Convert.ToString(num174);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "175")
                    {


                        textBox2.Text += Convert.ToString(num175);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "176")
                    {


                        textBox2.Text += Convert.ToString(num176);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "177")
                    {


                        textBox2.Text += Convert.ToString(num177);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "178")
                    {


                        textBox2.Text += Convert.ToString(num178);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "179")
                    {


                        textBox2.Text += Convert.ToString(num179);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "180")
                    {


                        textBox2.Text += Convert.ToString(num180);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "181")
                    {


                        textBox2.Text += Convert.ToString(num181);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "182")
                    {


                        textBox2.Text += Convert.ToString(num182);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "183")
                    {


                        textBox2.Text += Convert.ToString(num183);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "184")
                    {


                        textBox2.Text += Convert.ToString(num184);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "185")
                    {


                        textBox2.Text += Convert.ToString(num185);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "186")
                    {


                        textBox2.Text += Convert.ToString(num186);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "187")
                    {


                        textBox2.Text += Convert.ToString(num187);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "188")
                    {


                        textBox2.Text += Convert.ToString(num188);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "189")
                    {


                        textBox2.Text += Convert.ToString(num189);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "190")
                    {


                        textBox2.Text += Convert.ToString(num190);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "191")
                    {


                        textBox2.Text += Convert.ToString(num191);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "192")
                    {


                        textBox2.Text += Convert.ToString(num192);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "193")
                    {


                        textBox2.Text += Convert.ToString(num193);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "194")
                    {


                        textBox2.Text += Convert.ToString(num194);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "195")
                    {


                        textBox2.Text += Convert.ToString(num195);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "196")
                    {


                        textBox2.Text += Convert.ToString(num196);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "197")
                    {


                        textBox2.Text += Convert.ToString(num197);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "198")
                    {


                        textBox2.Text += Convert.ToString(num198);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "199")
                    {


                        textBox2.Text += Convert.ToString(num199);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "200")
                    {


                        textBox2.Text += Convert.ToString(num200);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "201")
                    {


                        textBox2.Text += Convert.ToString(num201);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }



                    if (chris == "202")
                    {


                        textBox2.Text += Convert.ToString(num202);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }



                    if (chris == "203")
                    {


                        textBox2.Text += Convert.ToString(num203);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "204")
                    {


                        textBox2.Text += Convert.ToString(num204);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "205")
                    {


                        textBox2.Text += Convert.ToString(num205);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "206")
                    {


                        textBox2.Text += Convert.ToString(num206);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "207")
                    {


                        textBox2.Text += Convert.ToString(num207);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "208")
                    {


                        textBox2.Text += Convert.ToString(num208);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "209")
                    {


                        textBox2.Text += Convert.ToString(num209);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "210")
                    {


                        textBox2.Text += Convert.ToString(num210);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }



                    if (chris == "211")
                    {


                        textBox2.Text += Convert.ToString(num211);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "212")
                    {


                        textBox2.Text += Convert.ToString(num212);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "213")
                    {


                        textBox2.Text += Convert.ToString(num213);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "214")
                    {


                        textBox2.Text += Convert.ToString(num214);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "215")
                    {


                        textBox2.Text += Convert.ToString(num215);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "216")
                    {


                        textBox2.Text += Convert.ToString(num216);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "217")
                    {


                        textBox2.Text += Convert.ToString(num217);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "218")
                    {


                        textBox2.Text += Convert.ToString(num218);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "219")
                    {


                        textBox2.Text += Convert.ToString(num219);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "220")
                    {


                        textBox2.Text += Convert.ToString(num220);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "221")
                    {


                        textBox2.Text += Convert.ToString(num221);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "222")
                    {


                        textBox2.Text += Convert.ToString(num222);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "223")
                    {


                        textBox2.Text += Convert.ToString(num223);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "224")
                    {


                        textBox2.Text += Convert.ToString(num224);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "225")
                    {


                        textBox2.Text += Convert.ToString(num225);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "226")
                    {


                        textBox2.Text += Convert.ToString(num226);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "227")
                    {


                        textBox2.Text += Convert.ToString(num227);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "228")
                    {


                        textBox2.Text += Convert.ToString(num228);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "229")
                    {


                        textBox2.Text += Convert.ToString(num229);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "230")
                    {


                        textBox2.Text += Convert.ToString(num230);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "231")
                    {


                        textBox2.Text += Convert.ToString(num231);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "232")
                    {


                        textBox2.Text += Convert.ToString(num232);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "233")
                    {


                        textBox2.Text += Convert.ToString(num233);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }



                    if (chris == "234")
                    {


                        textBox2.Text += Convert.ToString(num234);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }



                    if (chris == "235")
                    {


                        textBox2.Text += Convert.ToString(num235);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "236")
                    {


                        textBox2.Text += Convert.ToString(num236);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "237")
                    {


                        textBox2.Text += Convert.ToString(num237);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "238")
                    {


                        textBox2.Text += Convert.ToString(num238);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "239")
                    {


                        textBox2.Text += Convert.ToString(num239);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "240")
                    {


                        textBox2.Text += Convert.ToString(num240);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "241")
                    {


                        textBox2.Text += Convert.ToString(num241);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "242")
                    {


                        textBox2.Text += Convert.ToString(num242);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "243")
                    {


                        textBox2.Text += Convert.ToString(num243);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "244")
                    {


                        textBox2.Text += Convert.ToString(num244);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "245")
                    {


                        textBox2.Text += Convert.ToString(num245);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "246")
                    {


                        textBox2.Text += Convert.ToString(num246);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "247")
                    {


                        textBox2.Text += Convert.ToString(num247);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "248")
                    {


                        textBox2.Text += Convert.ToString(num248);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "249")
                    {


                        textBox2.Text += Convert.ToString(num249);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }


                    if (chris == "250")
                    {


                        textBox2.Text += Convert.ToString(num250);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "251")
                    {


                        textBox2.Text += Convert.ToString(num251);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "252")
                    {


                        textBox2.Text += Convert.ToString(num252);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "253")
                    {


                        textBox2.Text += Convert.ToString(num253);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "254")
                    {


                        textBox2.Text += Convert.ToString(num254);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }

                    if (chris == "255")
                    {


                        textBox2.Text += Convert.ToString(num255);
                        string path2 = "chris2.txt";
                        using (StreamWriter sw = File.CreateText((Application.ExecutablePath) + path2))
                        {

                            sw.WriteLine(textBox2.Text);

                        }
                    }





                }















            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            Random rnd = new Random();
            int dice = rnd.Next(1, 7);
            int dice2 = rnd.Next(1, 7);
            int dice3 = rnd.Next(1, 7);

            int dice4 = rnd.Next(1, 7);
            int dice5 = rnd.Next(1, 7);
            int dice6 = rnd.Next(1, 7);

            int dice7 = rnd.Next(1, 7);
            int dice8 = rnd.Next(1, 7);
            int dice9 = rnd.Next(1, 7);

            int dice10 = rnd.Next(1, 7);
            int dice11 = rnd.Next(1, 7);
            int dice12 = rnd.Next(1, 7);

            int dice13 = rnd.Next(1, 7);
            int dice14 = rnd.Next(1, 7);
            int dice15 = rnd.Next(1, 7);


            int dice16 = rnd.Next(1, 7);
            int dice17 = rnd.Next(1, 7);
            int dice18 = rnd.Next(1, 7);


            int dice19 = rnd.Next(1, 7);
            int dice20 = rnd.Next(1, 7);
            int dice21 = rnd.Next(1, 7);


            int dice22 = rnd.Next(1, 7);
            int dice23 = rnd.Next(1, 7);
            int dice24 = rnd.Next(1, 7);


            int dice25 = rnd.Next(1, 7);
            int dice26 = rnd.Next(1, 7);
            int dice27 = rnd.Next(1, 7);






            int dice28 = rnd.Next(1, 7);
            int dice29 = rnd.Next(1, 7);
            int dice30 = rnd.Next(1, 7);

            int dice31 = rnd.Next(1, 7);
            int dice32 = rnd.Next(1, 7);
            int dice33 = rnd.Next(1, 7);

            int dice34 = rnd.Next(1, 7);
            int dice35 = rnd.Next(1, 7);
            int dice36 = rnd.Next(1, 7);

            int dice37 = rnd.Next(1, 7);
            int dice38 = rnd.Next(1, 7);
            int dice39 = rnd.Next(1, 7);

            int dice40 = rnd.Next(1, 7);
            int dice41 = rnd.Next(1, 7);
            int dice42 = rnd.Next(1, 7);


            int dice43 = rnd.Next(1, 7);
            int dice44 = rnd.Next(1, 7);
            int dice45 = rnd.Next(1, 7);


            int dice46 = rnd.Next(1, 7);
            int dice47 = rnd.Next(1, 7);
            int dice48 = rnd.Next(1, 7);


            int dice49 = rnd.Next(1, 7);
            int dice50 = rnd.Next(1, 7);
            int dice51 = rnd.Next(1, 7);


            int dice52 = rnd.Next(1, 7);
            int dice53 = rnd.Next(1, 7);
            int dice54 = rnd.Next(1, 7);



            int dice55 = rnd.Next(1, 7);
            int dice56 = rnd.Next(1, 7);
            int dice57 = rnd.Next(1, 7);

            int dice58 = rnd.Next(1, 7);
            int dice59 = rnd.Next(1, 7);
            int dice60 = rnd.Next(1, 7);

            int dice61 = rnd.Next(1, 7);
            int dice62 = rnd.Next(1, 7);
            int dice63 = rnd.Next(1, 7);

            int dice64 = rnd.Next(1, 7);
            int dice65 = rnd.Next(1, 7);
            int dice66 = rnd.Next(1, 7);

            int dice67 = rnd.Next(1, 7);
            int dice68 = rnd.Next(1, 7);
            int dice69 = rnd.Next(1, 7);


            int dice70 = rnd.Next(1, 7);
            int dice71 = rnd.Next(1, 7);
            int dice72 = rnd.Next(1, 7);


            int dice73 = rnd.Next(1, 7);
            int dice74 = rnd.Next(1, 7);
            int dice75 = rnd.Next(1, 7);


            int dice76 = rnd.Next(1, 7);
            int dice77 = rnd.Next(1, 7);
            int dice78 = rnd.Next(1, 7);


            int dice79 = rnd.Next(1, 7);
            int dice80 = rnd.Next(1, 7);
            int dice81 = rnd.Next(1, 7);





            string k = Convert.ToString(dice) + Convert.ToString(dice2) + Convert.ToString(dice3);
            int kx = Convert.ToInt32(k);

            string k2 = Convert.ToString(dice4) + Convert.ToString(dice5) + Convert.ToString(dice6);
            int k2x = Convert.ToInt32(k2);

            string k3 = Convert.ToString(dice7) + Convert.ToString(dice8) + Convert.ToString(dice9);
            int k3x = Convert.ToInt32(k3);

            string k4 = Convert.ToString(dice10) + Convert.ToString(dice11) + Convert.ToString(dice12);
            int k4x = Convert.ToInt32(k4);

            string k5 = Convert.ToString(dice13) + Convert.ToString(dice14) + Convert.ToString(dice15);
            int k5x = Convert.ToInt32(k5);

            string k6 = Convert.ToString(dice16) + Convert.ToString(dice17) + Convert.ToString(dice18);
            int k6x = Convert.ToInt32(k6);

            string k7 = Convert.ToString(dice19) + Convert.ToString(dice20) + Convert.ToString(dice21);
            int k7x = Convert.ToInt32(k7);

            string k8 = Convert.ToString(dice22) + Convert.ToString(dice23) + Convert.ToString(dice24);
            int k8x = Convert.ToInt32(k8);

            string k9 = Convert.ToString(dice25) + Convert.ToString(dice26) + Convert.ToString(dice27);
            int k9x = Convert.ToInt32(k9);

            string k10 = Convert.ToString(dice28) + Convert.ToString(dice29) + Convert.ToString(dice30);
            int k10x = Convert.ToInt32(k10);

            string k11 = Convert.ToString(dice31) + Convert.ToString(dice32) + Convert.ToString(dice33);
            int k11x = Convert.ToInt32(k11);

            string k12 = Convert.ToString(dice34) + Convert.ToString(dice35) + Convert.ToString(dice36);
            int k12x = Convert.ToInt32(k12);

            string k13 = Convert.ToString(dice37) + Convert.ToString(dice38) + Convert.ToString(dice39);
            int k13x = Convert.ToInt32(k13);

            string k14 = Convert.ToString(dice40) + Convert.ToString(dice41) + Convert.ToString(dice42);
            int k14x = Convert.ToInt32(k14);

            string k15 = Convert.ToString(dice43) + Convert.ToString(dice44) + Convert.ToString(dice45);
            int k15x = Convert.ToInt32(k15);

            string k16 = Convert.ToString(dice46) + Convert.ToString(dice47) + Convert.ToString(dice48);
            int k16x = Convert.ToInt32(k16);

            string k17 = Convert.ToString(dice49) + Convert.ToString(dice50) + Convert.ToString(dice51);
            int k17x = Convert.ToInt32(k17);

            string k18 = Convert.ToString(dice52) + Convert.ToString(dice53) + Convert.ToString(dice54);
            int k18x = Convert.ToInt32(k18);

            string k19 = Convert.ToString(dice55) + Convert.ToString(dice56) + Convert.ToString(dice57);
            int k19x = Convert.ToInt32(k19);

            string k20 = Convert.ToString(dice58) + Convert.ToString(dice59) + Convert.ToString(dice60);
            int k20x = Convert.ToInt32(k20);

            string k21 = Convert.ToString(dice61) + Convert.ToString(dice62) + Convert.ToString(dice63);
            int k21x = Convert.ToInt32(k21);

            string k22 = Convert.ToString(dice64) + Convert.ToString(dice65) + Convert.ToString(dice66);
            int k22x = Convert.ToInt32(k22);

            string k23 = Convert.ToString(dice67) + Convert.ToString(dice68) + Convert.ToString(dice69);
            int k23x = Convert.ToInt32(k23);

            string k24 = Convert.ToString(dice70) + Convert.ToString(dice71) + Convert.ToString(dice72);
            int k24x = Convert.ToInt32(k24);

            string k25 = Convert.ToString(dice73) + Convert.ToString(dice74) + Convert.ToString(dice75);
            int k25x = Convert.ToInt32(k25);

            string k26 = Convert.ToString(dice76) + Convert.ToString(dice77) + Convert.ToString(dice78);
            int k26x = Convert.ToInt32(k26);

            string k27 = Convert.ToString(dice79) + Convert.ToString(dice80) + Convert.ToString(dice81);
            int k27x = Convert.ToInt32(k27);

            if (kx != k2x || k3x != k4x || k5x != k6x || k7x != k8x || k9x != k10x || k11x != k12x || k13x != k14x || k15x != k16x || k17x != k18x || k19x != k20x || k21x != k22x || k23x != k24x || k25x != k26x || k26x != k27x)
            {


                textBox14.Text = k + k2 + k3 + k4 + k5 + k6 + k7 + k8 + k9 + k10 + k11 + k12 + k13 + k14 + k15 + k16 + k17 + k18 + k19 + k20 + k21 + k22 + k23 + k24 + k25 + k26 + k27;
            }

        }


        private void button6_Click(object sender, EventArgs e)
        {

            textBox2.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();


            int k = rnd.Next(260, 999);
            int k2 = rnd.Next(100, 999);
            int k3 = rnd.Next(100, 999);
            int k4 = rnd.Next(100, 999);
            int k5 = rnd.Next(100, 999);
            int k6 = rnd.Next(100, 999);
            int k7 = rnd.Next(100, 999);
            int k8 = rnd.Next(100, 999);
            int k9 = rnd.Next(100, 999);

            textBox5.Text = Convert.ToString(k);

            textBox6.Text = Convert.ToString(k2);

            textBox7.Text = Convert.ToString(k3);

            textBox10.Text = Convert.ToString(k4);

            textBox9.Text = Convert.ToString(k5);

            textBox8.Text = Convert.ToString(k6);

            textBox13.Text = Convert.ToString(k7);

            textBox12.Text = Convert.ToString(k8);

            textBox11.Text = Convert.ToString(k9);




        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            char a1 = Convert.ToChar(1);
            char a2 = Convert.ToChar(2);
            char a3 = Convert.ToChar(3);
            char a4 = Convert.ToChar(4);
            char a5 = Convert.ToChar(5);
            char a6 = Convert.ToChar(6);
            char a7 = Convert.ToChar(7);
            char a8 = Convert.ToChar(8);
            char a9 = Convert.ToChar(9);
            char a10 = Convert.ToChar(10);
            char a11 = Convert.ToChar(11);
            char a12 = Convert.ToChar(12);
            char a13 = Convert.ToChar(13);
            char a14 = Convert.ToChar(14);
            char a15 = Convert.ToChar(15);
            char a16 = Convert.ToChar(16);
            char a17 = Convert.ToChar(17);
            char a18 = Convert.ToChar(18);
            char a19 = Convert.ToChar(19);
            char a20 = Convert.ToChar(20);
            char a21 = Convert.ToChar(21);
            char a22 = Convert.ToChar(22);
            char a23 = Convert.ToChar(23);
            char a24 = Convert.ToChar(24);
            char a25 = Convert.ToChar(25);
            char a26 = Convert.ToChar(26);
            char a27 = Convert.ToChar(27);
            char a28 = Convert.ToChar(28);
            char a29 = Convert.ToChar(29);
            char a30 = Convert.ToChar(30);
            char a31 = Convert.ToChar(31);
            char a32 = Convert.ToChar(32);
            char a33 = Convert.ToChar(33);
            char a34 = Convert.ToChar(34);
            char a35 = Convert.ToChar(35);
            char a36 = Convert.ToChar(36);
            char a37 = Convert.ToChar(37);
            char a38 = Convert.ToChar(38);
            char a39 = Convert.ToChar(39);
            char a40 = Convert.ToChar(40);
            char a41 = Convert.ToChar(41);
            char a42 = Convert.ToChar(42);
            char a43 = Convert.ToChar(43);
            char a44 = Convert.ToChar(44);
            char a45 = Convert.ToChar(45);
            char a46 = Convert.ToChar(46);
            char a47 = Convert.ToChar(47);
            char a48 = Convert.ToChar(48);
            char a49 = Convert.ToChar(49);
            char a50 = Convert.ToChar(50);
            char a51 = Convert.ToChar(51);
            char a52 = Convert.ToChar(52);
            char a53 = Convert.ToChar(53);
            char a54 = Convert.ToChar(54);
            char a55 = Convert.ToChar(55);
            char a56 = Convert.ToChar(56);
            char a57 = Convert.ToChar(57);
            char a58 = Convert.ToChar(58);
            char a59 = Convert.ToChar(59);
            char a60 = Convert.ToChar(60);
            char a61 = Convert.ToChar(61);
            char a62 = Convert.ToChar(62);
            char a63 = Convert.ToChar(63);
            char a64 = Convert.ToChar(64);
            char a65 = Convert.ToChar(65);
            char a66 = Convert.ToChar(66);
            char a67 = Convert.ToChar(67);
            char a68 = Convert.ToChar(68);
            char a69 = Convert.ToChar(69);
            char a70 = Convert.ToChar(70);
            char a71 = Convert.ToChar(71);
            char a72 = Convert.ToChar(72);
            char a73 = Convert.ToChar(73);
            char a74 = Convert.ToChar(74);
            char a75 = Convert.ToChar(75);
            char a76 = Convert.ToChar(76);
            char a77 = Convert.ToChar(77);
            char a78 = Convert.ToChar(78);
            char a79 = Convert.ToChar(79);
            char a80 = Convert.ToChar(80);
            char a81 = Convert.ToChar(81);
            char a82 = Convert.ToChar(82);
            char a83 = Convert.ToChar(83);
            char a84 = Convert.ToChar(84);
            char a85 = Convert.ToChar(85);
            char a86 = Convert.ToChar(86);
            char a87 = Convert.ToChar(87);
            char a88 = Convert.ToChar(88);
            char a89 = Convert.ToChar(89);
            char a90 = Convert.ToChar(90);
            char a91 = Convert.ToChar(91);
            char a92 = Convert.ToChar(92);
            char a93 = Convert.ToChar(93);
            char a94 = Convert.ToChar(94);
            char a95 = Convert.ToChar(95);
            char a96 = Convert.ToChar(96);
            char a97 = Convert.ToChar(97);
            char a98 = Convert.ToChar(98);
            char a99 = Convert.ToChar(99);
            char a100 = Convert.ToChar(100);
            char a101 = Convert.ToChar(101);
            char a102 = Convert.ToChar(102);
            char a103 = Convert.ToChar(103);
            char a104 = Convert.ToChar(104);
            char a105 = Convert.ToChar(105);
            char a106 = Convert.ToChar(106);
            char a107 = Convert.ToChar(107);
            char a108 = Convert.ToChar(108);
            char a109 = Convert.ToChar(109);
            char a110 = Convert.ToChar(110);
            char a111 = Convert.ToChar(111);
            char a112 = Convert.ToChar(112);
            char a113 = Convert.ToChar(113);
            char a114 = Convert.ToChar(114);
            char a115 = Convert.ToChar(115);
            char a116 = Convert.ToChar(116);
            char a117 = Convert.ToChar(117);
            char a118 = Convert.ToChar(118);
            char a119 = Convert.ToChar(119);
            char a120 = Convert.ToChar(120);
            char a121 = Convert.ToChar(121);
            char a122 = Convert.ToChar(122);
            char a123 = Convert.ToChar(123);
            char a124 = Convert.ToChar(124);
            char a125 = Convert.ToChar(125);
            char a126 = Convert.ToChar(126);
            char a127 = Convert.ToChar(127);
            char a128 = Convert.ToChar(128);
            char a129 = Convert.ToChar(129);
            char a130 = Convert.ToChar(130);
            char a131 = Convert.ToChar(131);
            char a132 = Convert.ToChar(132);
            char a133 = Convert.ToChar(133);
            char a134 = Convert.ToChar(134);
            char a135 = Convert.ToChar(135);
            char a136 = Convert.ToChar(136);
            char a137 = Convert.ToChar(137);
            char a138 = Convert.ToChar(138);
            char a139 = Convert.ToChar(139);
            char a140 = Convert.ToChar(140);
            char a141 = Convert.ToChar(141);
            char a142 = Convert.ToChar(142);
            char a143 = Convert.ToChar(143);
            char a144 = Convert.ToChar(144);
            char a145 = Convert.ToChar(145);
            char a146 = Convert.ToChar(146);
            char a147 = Convert.ToChar(147);
            char a148 = Convert.ToChar(148);
            char a149 = Convert.ToChar(149);
            char a150 = Convert.ToChar(150);
            char a151 = Convert.ToChar(151);
            char a152 = Convert.ToChar(152);
            char a153 = Convert.ToChar(153);
            char a154 = Convert.ToChar(154);
            char a155 = Convert.ToChar(155);
            char a156 = Convert.ToChar(156);
            char a157 = Convert.ToChar(157);
            char a158 = Convert.ToChar(158);
            char a159 = Convert.ToChar(159);
            char a160 = Convert.ToChar(160);
            char a161 = Convert.ToChar(161);
            char a162 = Convert.ToChar(162);
            char a163 = Convert.ToChar(163);
            char a164 = Convert.ToChar(164);
            char a165 = Convert.ToChar(165);
            char a166 = Convert.ToChar(166);
            char a167 = Convert.ToChar(167);
            char a168 = Convert.ToChar(168);
            char a169 = Convert.ToChar(169);
            char a170 = Convert.ToChar(170);
            char a171 = Convert.ToChar(171);
            char a172 = Convert.ToChar(172);
            char a173 = Convert.ToChar(173);
            char a174 = Convert.ToChar(174);
            char a175 = Convert.ToChar(175);
            char a176 = Convert.ToChar(176);
            char a177 = Convert.ToChar(177);
            char a178 = Convert.ToChar(178);
            char a179 = Convert.ToChar(179);
            char a180 = Convert.ToChar(180);
            char a181 = Convert.ToChar(181);
            char a182 = Convert.ToChar(182);
            char a183 = Convert.ToChar(183);
            char a184 = Convert.ToChar(184);
            char a185 = Convert.ToChar(185);
            char a186 = Convert.ToChar(186);
            char a187 = Convert.ToChar(187);
            char a188 = Convert.ToChar(188);
            char a189 = Convert.ToChar(189);
            char a190 = Convert.ToChar(190);
            char a191 = Convert.ToChar(191);
            char a192 = Convert.ToChar(192);
            char a193 = Convert.ToChar(193);
            char a194 = Convert.ToChar(194);
            char a195 = Convert.ToChar(195);
            char a196 = Convert.ToChar(196);
            char a197 = Convert.ToChar(197);
            char a198 = Convert.ToChar(198);
            char a199 = Convert.ToChar(199);
            char a200 = Convert.ToChar(200);
            char a201 = Convert.ToChar(201);
            char a202 = Convert.ToChar(202);
            char a203 = Convert.ToChar(203);
            char a204 = Convert.ToChar(204);
            char a205 = Convert.ToChar(205);
            char a206 = Convert.ToChar(206);
            char a207 = Convert.ToChar(207);
            char a208 = Convert.ToChar(208);
            char a209 = Convert.ToChar(209);
            char a210 = Convert.ToChar(210);
            char a211 = Convert.ToChar(211);
            char a212 = Convert.ToChar(212);
            char a213 = Convert.ToChar(213);
            char a214 = Convert.ToChar(214);
            char a215 = Convert.ToChar(215);
            char a216 = Convert.ToChar(216);
            char a217 = Convert.ToChar(217);
            char a218 = Convert.ToChar(218);
            char a219 = Convert.ToChar(219);
            char a220 = Convert.ToChar(220);
            char a221 = Convert.ToChar(221);
            char a222 = Convert.ToChar(222);
            char a223 = Convert.ToChar(223);
            char a224 = Convert.ToChar(224);
            char a225 = Convert.ToChar(225);
            char a226 = Convert.ToChar(226);
            char a227 = Convert.ToChar(227);
            char a228 = Convert.ToChar(228);
            char a229 = Convert.ToChar(229);
            char a230 = Convert.ToChar(230);
            char a231 = Convert.ToChar(231);
            char a232 = Convert.ToChar(232);
            char a233 = Convert.ToChar(233);
            char a234 = Convert.ToChar(234);
            char a235 = Convert.ToChar(235);
            char a236 = Convert.ToChar(236);
            char a237 = Convert.ToChar(237);
            char a238 = Convert.ToChar(238);
            char a239 = Convert.ToChar(239);
            char a240 = Convert.ToChar(240);
            char a241 = Convert.ToChar(241);
            char a242 = Convert.ToChar(242);
            char a243 = Convert.ToChar(243);
            char a244 = Convert.ToChar(244);
            char a245 = Convert.ToChar(245);
            char a246 = Convert.ToChar(246);
            char a247 = Convert.ToChar(247);
            char a248 = Convert.ToChar(248);
            char a249 = Convert.ToChar(249);
            char a250 = Convert.ToChar(250);
            char a251 = Convert.ToChar(251);
            char a252 = Convert.ToChar(252);
            char a253 = Convert.ToChar(253);
            char a254 = Convert.ToChar(254);
            char a255 = Convert.ToChar(255);


        }


        private void button8_Click(object sender, EventArgs e)
        {

            Random rnd = new Random();

            int b = 1, b2 = 1;
            while (b <= 36)
            {


                int dice = rnd.Next(0, 9);
                int dice2 = rnd.Next(0, 9);
                int dice3 = rnd.Next(0, 9);


                int dice4 = rnd.Next(0, 9);
                int dice5 = rnd.Next(0, 9);
                int dice6 = rnd.Next(0, 9);

                string k = Convert.ToString(dice) + Convert.ToString(dice2) + Convert.ToString(dice3);


                string k2 = Convert.ToString(dice4) + Convert.ToString(dice5) + Convert.ToString(dice6);



                textBox15.Text += Convert.ToString(k) + Convert.ToString(k2);

                b++;

                while (b2 <= 10000000)
                {
                    b2++;

                }
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox15.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {


            string box = textBox14.Text;


            for (int i = 0; i < 81; i++)
            {


                string x = box.Substring(i, 1);
                textBox16.Text += x;

                
                int xx = Convert.ToInt32(x);

                i++;
                string y = box.Substring(i, 1);
                textBox17.Text += y;
                int yy = Convert.ToInt32(y);

                i++;
                string z = box.Substring(i, 1);
                textBox18.Text += z;
                int zz = Convert.ToInt32(z);


                if (zz == 1)
                {



                    if (yy == 1)
                    {

                        int me = xx + 0;





                        string test = Convert.ToString(me);
                        textBox19.Text += test + ".";



                        //Plaintext code
                        //Gets a char from string.
                        string n = textBox2.Text;

                        string nn = n.Substring(0, 1);

                        //6x6x6 matrix
                        //Removes a spot from string.
                        string MyString = textBox15.Text;
                        string work = MyString.Remove(Convert.ToInt32(me), 1);
                        textBox1.Text = work;


                        //encodes 6x6x6 matrix
                        //inserts in a spot on a string.
                        String original = textBox1.Text;
                        String modified = original.Insert(Convert.ToInt32(me), nn);
                        textBox1.Text = modified;

                    }


                    if (yy == 2)
                    {

                        int me = xx + 6;





                        string test = Convert.ToString(me);
                        textBox19.Text += test + ".";



                        //Plaintext code
                        //Gets a char from string.
                        string n = textBox2.Text;

                        string nn = n.Substring(0, 1);

                        //6x6x6 matrix
                        //Removes a spot from string.
                        string MyString = textBox15.Text;
                        string work = MyString.Remove(Convert.ToInt32(me), 1);
                        textBox1.Text = work;


                        //encodes 6x6x6 matrix
                        //inserts in a spot on a string.
                        String original = textBox1.Text;
                        String modified = original.Insert(Convert.ToInt32(me), nn);
                        textBox1.Text = modified;

                    }



                    if (yy == 3)
                    {

                        int me = xx + 12;





                        string test = Convert.ToString(me);
                        textBox19.Text += test + ".";



                        //Plaintext code
                        //Gets a char from string.
                        string n = textBox2.Text;

                        string nn = n.Substring(0, 1);

                        //6x6x6 matrix
                        //Removes a spot from string.
                        string MyString = textBox15.Text;
                        string work = MyString.Remove(Convert.ToInt32(me), 1);
                        textBox1.Text = work;


                        //encodes 6x6x6 matrix
                        //inserts in a spot on a string.
                        String original = textBox1.Text;
                        String modified = original.Insert(Convert.ToInt32(me), nn);
                        textBox1.Text = modified;

                    }


                    if (yy == 4)
                    {

                        int me = xx + 18;





                        string test = Convert.ToString(me);
                        textBox19.Text += test + ".";



                        //Plaintext code
                        //Gets a char from string.
                        string n = textBox2.Text;

                        string nn = n.Substring(0, 1);

                        //6x6x6 matrix
                        //Removes a spot from string.
                        string MyString = textBox15.Text;
                        string work = MyString.Remove(Convert.ToInt32(me), 1);
                        textBox1.Text = work;


                        //encodes 6x6x6 matrix
                        //inserts in a spot on a string.
                        String original = textBox1.Text;
                        String modified = original.Insert(Convert.ToInt32(me), nn);
                        textBox1.Text = modified;

                    }



                    if (yy == 5)
                    {

                        int me = xx + 24;





                        string test = Convert.ToString(me);
                        textBox19.Text += test + ".";



                        //Plaintext code
                        //Gets a char from string.
                        string n = textBox2.Text;

                        string nn = n.Substring(0, 1);

                        //6x6x6 matrix
                        //Removes a spot from string.
                        string MyString = textBox15.Text;
                        string work = MyString.Remove(Convert.ToInt32(me), 1);
                        textBox1.Text = work;


                        //encodes 6x6x6 matrix
                        //inserts in a spot on a string.
                        String original = textBox1.Text;
                        String modified = original.Insert(Convert.ToInt32(me), nn);
                        textBox1.Text = modified;

                    }


                    if (yy == 6)
                    {

                        int me = xx + 30;





                        string test = Convert.ToString(me);
                        textBox19.Text += test + ".";



                        //Plaintext code
                        //Gets a char from string.
                        string n = textBox2.Text;

                        string nn = n.Substring(0, 1);

                        //6x6x6 matrix
                        //Removes a spot from string.
                        string MyString = textBox15.Text;
                        string work = MyString.Remove(Convert.ToInt32(me), 1);
                        textBox1.Text = work;


                        //encodes 6x6x6 matrix
                        //inserts in a spot on a string.
                        String original = textBox1.Text;
                        String modified = original.Insert(Convert.ToInt32(me), nn);
                        textBox1.Text = modified;

                    }


                    if (zz == 2)
                    {



                        if (yy == 1)
                        {

                            int me = xx + 36;





                            string test = Convert.ToString(me);
                            textBox19.Text += test + ".";



                            //Plaintext code
                            //Gets a char from string.
                            string n = textBox2.Text;

                            string nn = n.Substring(0, 1);

                            //6x6x6 matrix
                            //Removes a spot from string.
                            string MyString = textBox15.Text;
                            string work = MyString.Remove(Convert.ToInt32(me), 1);
                            textBox1.Text = work;


                            //encodes 6x6x6 matrix
                            //inserts in a spot on a string.
                            String original = textBox1.Text;
                            String modified = original.Insert(Convert.ToInt32(me), nn);
                            textBox1.Text = modified;

                        }


                        if (yy == 2)
                        {

                            int me = xx + 6 + 36;





                            string test = Convert.ToString(me);
                            textBox19.Text += test + ".";



                            //Plaintext code
                            //Gets a char from string.
                            string n = textBox2.Text;

                            string nn = n.Substring(0, 1);

                            //6x6x6 matrix
                            //Removes a spot from string.
                            string MyString = textBox15.Text;
                            string work = MyString.Remove(Convert.ToInt32(me), 1);
                            textBox1.Text = work;


                            //encodes 6x6x6 matrix
                            //inserts in a spot on a string.
                            String original = textBox1.Text;
                            String modified = original.Insert(Convert.ToInt32(me), nn);
                            textBox1.Text = modified;

                        }



                        if (yy == 3)
                        {

                            int me = xx + 12 + 36;





                            string test = Convert.ToString(me);
                            textBox19.Text += test + ".";



                            //Plaintext code
                            //Gets a char from string.
                            string n = textBox2.Text;

                            string nn = n.Substring(0, 1);

                            //6x6x6 matrix
                            //Removes a spot from string.
                            string MyString = textBox15.Text;
                            string work = MyString.Remove(Convert.ToInt32(me), 1);
                            textBox1.Text = work;


                            //encodes 6x6x6 matrix
                            //inserts in a spot on a string.
                            String original = textBox1.Text;
                            String modified = original.Insert(Convert.ToInt32(me), nn);
                            textBox1.Text = modified;

                        }


                        if (yy == 4)
                        {

                            int me = xx + 18 + 36;





                            string test = Convert.ToString(me);
                            textBox19.Text += test + ".";



                            //Plaintext code
                            //Gets a char from string.
                            string n = textBox2.Text;

                            string nn = n.Substring(0, 1);

                            //6x6x6 matrix
                            //Removes a spot from string.
                            string MyString = textBox15.Text;
                            string work = MyString.Remove(Convert.ToInt32(me), 1);
                            textBox1.Text = work;


                            //encodes 6x6x6 matrix
                            //inserts in a spot on a string.
                            String original = textBox1.Text;
                            String modified = original.Insert(Convert.ToInt32(me), nn);
                            textBox1.Text = modified;

                        }



                        if (yy == 5)
                        {

                            int me = xx + 24 + 36;





                            string test = Convert.ToString(me);
                            textBox19.Text += test + ".";



                            //Plaintext code
                            //Gets a char from string.
                            string n = textBox2.Text;

                            string nn = n.Substring(0, 1);

                            //6x6x6 matrix
                            //Removes a spot from string.
                            string MyString = textBox15.Text;
                            string work = MyString.Remove(Convert.ToInt32(me), 1);
                            textBox1.Text = work;


                            //encodes 6x6x6 matrix
                            //inserts in a spot on a string.
                            String original = textBox1.Text;
                            String modified = original.Insert(Convert.ToInt32(me), nn);
                            textBox1.Text = modified;

                        }


                        if (yy == 6)
                        {

                            int me = xx + 30 + 36;





                            string test = Convert.ToString(me);
                            textBox19.Text += test + ".";



                            //Plaintext code
                            //Gets a char from string.
                            string n = textBox2.Text;

                            string nn = n.Substring(0, 1);

                            //6x6x6 matrix
                            //Removes a spot from string.
                            string MyString = textBox15.Text;
                            string work = MyString.Remove(Convert.ToInt32(me), 1);
                            textBox1.Text = work;


                            //encodes 6x6x6 matrix
                            //inserts in a spot on a string.
                            String original = textBox1.Text;
                            String modified = original.Insert(Convert.ToInt32(me), nn);
                            textBox1.Text = modified;

                        }

                        if (zz == 3)
                        {



                            if (yy == 1)
                            {

                                int me = xx + 36 + 36;





                                string test = Convert.ToString(me);
                                textBox19.Text += test + ".";



                                //Plaintext code
                                //Gets a char from string.
                                string n = textBox2.Text;

                                string nn = n.Substring(0, 1);

                                //6x6x6 matrix
                                //Removes a spot from string.
                                string MyString = textBox15.Text;
                                string work = MyString.Remove(Convert.ToInt32(me), 1);
                                textBox1.Text = work;


                                //encodes 6x6x6 matrix
                                //inserts in a spot on a string.
                                String original = textBox1.Text;
                                String modified = original.Insert(Convert.ToInt32(me), nn);
                                textBox1.Text = modified;

                            }


                            if (yy == 2)
                            {

                                int me = xx + 6 + 36 + 36;





                                string test = Convert.ToString(me);
                                textBox19.Text += test + ".";



                                //Plaintext code
                                //Gets a char from string.
                                string n = textBox2.Text;

                                string nn = n.Substring(0, 1);

                                //6x6x6 matrix
                                //Removes a spot from string.
                                string MyString = textBox15.Text;
                                string work = MyString.Remove(Convert.ToInt32(me), 1);
                                textBox1.Text = work;


                                //encodes 6x6x6 matrix
                                //inserts in a spot on a string.
                                String original = textBox1.Text;
                                String modified = original.Insert(Convert.ToInt32(me), nn);
                                textBox1.Text = modified;

                            }



                            if (yy == 3)
                            {

                                int me = xx + 12 + 36 + 36;





                                string test = Convert.ToString(me);
                                textBox19.Text += test + ".";



                                //Plaintext code
                                //Gets a char from string.
                                string n = textBox2.Text;

                                string nn = n.Substring(0, 1);

                                //6x6x6 matrix
                                //Removes a spot from string.
                                string MyString = textBox15.Text;
                                string work = MyString.Remove(Convert.ToInt32(me), 1);
                                textBox1.Text = work;


                                //encodes 6x6x6 matrix
                                //inserts in a spot on a string.
                                String original = textBox1.Text;
                                String modified = original.Insert(Convert.ToInt32(me), nn);
                                textBox1.Text = modified;

                            }


                            if (yy == 4)
                            {

                                int me = xx + 18 + 36 + 36;






                                string test = Convert.ToString(me);
                                textBox19.Text += test + ".";



                                //Plaintext code
                                //Gets a char from string.
                                string n = textBox2.Text;

                                string nn = n.Substring(0, 1);

                                //6x6x6 matrix
                                //Removes a spot from string.
                                string MyString = textBox15.Text;
                                string work = MyString.Remove(Convert.ToInt32(me), 1);
                                textBox1.Text = work;


                                //encodes 6x6x6 matrix
                                //inserts in a spot on a string.
                                String original = textBox1.Text;
                                String modified = original.Insert(Convert.ToInt32(me), nn);
                                textBox1.Text = modified;

                            }



                            if (yy == 5)
                            {

                                int me = xx + 24 + 36 + 36;





                                string test = Convert.ToString(me);
                                textBox19.Text += test + ".";



                                //Plaintext code
                                //Gets a char from string.
                                string n = textBox2.Text;

                                string nn = n.Substring(0, 1);

                                //6x6x6 matrix
                                //Removes a spot from string.
                                string MyString = textBox15.Text;
                                string work = MyString.Remove(Convert.ToInt32(me), 1);
                                textBox1.Text = work;


                                //encodes 6x6x6 matrix
                                //inserts in a spot on a string.
                                String original = textBox1.Text;
                                String modified = original.Insert(Convert.ToInt32(me), nn);
                                textBox1.Text = modified;

                            }


                            if (yy == 6)
                            {

                                int me = xx + 30 + 36 + 36;





                                string test = Convert.ToString(me);
                                textBox19.Text += test + ".";



                                //Plaintext code
                                //Gets a char from string.
                                string n = textBox2.Text;

                                string nn = n.Substring(0, 1);

                                //6x6x6 matrix
                                //Removes a spot from string.
                                string MyString = textBox15.Text;
                                string work = MyString.Remove(Convert.ToInt32(me), 1);
                                textBox1.Text = work;


                                //encodes 6x6x6 matrix
                                //inserts in a spot on a string.
                                String original = textBox1.Text;
                                String modified = original.Insert(Convert.ToInt32(me), nn);
                                textBox1.Text = modified;

                            }



                            if (zz == 4)
                            {



                                if (yy == 1)
                                {

                                    int me = xx + 36 + 36 + 36;





                                    string test = Convert.ToString(me);
                                    textBox19.Text += test + ".";



                                    //Plaintext code
                                    //Gets a char from string.
                                    string n = textBox2.Text;

                                    string nn = n.Substring(0, 1);

                                    //6x6x6 matrix
                                    //Removes a spot from string.
                                    string MyString = textBox15.Text;
                                    string work = MyString.Remove(Convert.ToInt32(me), 1);
                                    textBox1.Text = work;


                                    //encodes 6x6x6 matrix
                                    //inserts in a spot on a string.
                                    String original = textBox1.Text;
                                    String modified = original.Insert(Convert.ToInt32(me), nn);
                                    textBox1.Text = modified;

                                }


                                if (yy == 2)
                                {

                                    int me = xx + 6 + 36 + 36 + 36;





                                    string test = Convert.ToString(me);
                                    textBox19.Text += test + ".";



                                    //Plaintext code
                                    //Gets a char from string.
                                    string n = textBox2.Text;

                                    string nn = n.Substring(0, 1);

                                    //6x6x6 matrix
                                    //Removes a spot from string.
                                    string MyString = textBox15.Text;
                                    string work = MyString.Remove(Convert.ToInt32(me), 1);
                                    textBox1.Text = work;


                                    //encodes 6x6x6 matrix
                                    //inserts in a spot on a string.
                                    String original = textBox1.Text;
                                    String modified = original.Insert(Convert.ToInt32(me), nn);
                                    textBox1.Text = modified;

                                }



                                if (yy == 3)
                                {

                                    int me = xx + 12 + 36 + 36 + 36;





                                    string test = Convert.ToString(me);
                                    textBox19.Text += test + ".";



                                    //Plaintext code
                                    //Gets a char from string.
                                    string n = textBox2.Text;

                                    string nn = n.Substring(0, 1);

                                    //6x6x6 matrix
                                    //Removes a spot from string.
                                    string MyString = textBox15.Text;
                                    string work = MyString.Remove(Convert.ToInt32(me), 1);
                                    textBox1.Text = work;


                                    //encodes 6x6x6 matrix
                                    //inserts in a spot on a string.
                                    String original = textBox1.Text;
                                    String modified = original.Insert(Convert.ToInt32(me), nn);
                                    textBox1.Text = modified;

                                }


                                if (yy == 4)
                                {

                                    int me = xx + 18 + 36 + 36 + 36;






                                    string test = Convert.ToString(me);
                                    textBox19.Text += test + ".";



                                    //Plaintext code
                                    //Gets a char from string.
                                    string n = textBox2.Text;

                                    string nn = n.Substring(0, 1);

                                    //6x6x6 matrix
                                    //Removes a spot from string.
                                    string MyString = textBox15.Text;
                                    string work = MyString.Remove(Convert.ToInt32(me), 1);
                                    textBox1.Text = work;


                                    //encodes 6x6x6 matrix
                                    //inserts in a spot on a string.
                                    String original = textBox1.Text;
                                    String modified = original.Insert(Convert.ToInt32(me), nn);
                                    textBox1.Text = modified;

                                }



                                if (yy == 5)
                                {

                                    int me = xx + 24 + 36 + 36 + 36;





                                    string test = Convert.ToString(me);
                                    textBox19.Text += test + ".";



                                    //Plaintext code
                                    //Gets a char from string.
                                    string n = textBox2.Text;

                                    string nn = n.Substring(0, 1);

                                    //6x6x6 matrix
                                    //Removes a spot from string.
                                    string MyString = textBox15.Text;
                                    string work = MyString.Remove(Convert.ToInt32(me), 1);
                                    textBox1.Text = work;


                                    //encodes 6x6x6 matrix
                                    //inserts in a spot on a string.
                                    String original = textBox1.Text;
                                    String modified = original.Insert(Convert.ToInt32(me), nn);
                                    textBox1.Text = modified;

                                }


                                if (yy == 6)
                                {

                                    int me = xx + 30 + 36 + 36 + 36;





                                    string test = Convert.ToString(me);
                                    textBox19.Text += test + ".";



                                    //Plaintext code
                                    //Gets a char from string.
                                    string n = textBox2.Text;

                                    string nn = n.Substring(0, 1);

                                    //6x6x6 matrix
                                    //Removes a spot from string.
                                    string MyString = textBox15.Text;
                                    string work = MyString.Remove(Convert.ToInt32(me), 1);
                                    textBox1.Text = work;


                                    //encodes 6x6x6 matrix
                                    //inserts in a spot on a string.
                                    String original = textBox1.Text;
                                    String modified = original.Insert(Convert.ToInt32(me), nn);
                                    textBox1.Text = modified;

                                }


                                if (zz == 5)
                                {



                                    if (yy == 1)
                                    {

                                        int me = xx + 36 + 36 + 36 + 36;





                                        string test = Convert.ToString(me);
                                        textBox19.Text += test + ".";



                                        //Plaintext code
                                        //Gets a char from string.
                                        string n = textBox2.Text;

                                        string nn = n.Substring(0, 1);

                                        //6x6x6 matrix
                                        //Removes a spot from string.
                                        string MyString = textBox15.Text;
                                        string work = MyString.Remove(Convert.ToInt32(me), 1);
                                        textBox1.Text = work;


                                        //encodes 6x6x6 matrix
                                        //inserts in a spot on a string.
                                        String original = textBox1.Text;
                                        String modified = original.Insert(Convert.ToInt32(me), nn);
                                        textBox1.Text = modified;

                                    }


                                    if (yy == 2)
                                    {

                                        int me = xx + 6 + 36 + 36 + 36 + 36;





                                        string test = Convert.ToString(me);
                                        textBox19.Text += test + ".";



                                        //Plaintext code
                                        //Gets a char from string.
                                        string n = textBox2.Text;

                                        string nn = n.Substring(0, 1);

                                        //6x6x6 matrix
                                        //Removes a spot from string.
                                        string MyString = textBox15.Text;
                                        string work = MyString.Remove(Convert.ToInt32(me), 1);
                                        textBox1.Text = work;


                                        //encodes 6x6x6 matrix
                                        //inserts in a spot on a string.
                                        String original = textBox1.Text;
                                        String modified = original.Insert(Convert.ToInt32(me), nn);
                                        textBox1.Text = modified;

                                    }



                                    if (yy == 3)
                                    {

                                        int me = xx + 12 + 36 + 36 + 36 + 36;





                                        string test = Convert.ToString(me);
                                        textBox19.Text += test + ".";



                                        //Plaintext code
                                        //Gets a char from string.
                                        string n = textBox2.Text;

                                        string nn = n.Substring(0, 1);

                                        //6x6x6 matrix
                                        //Removes a spot from string.
                                        string MyString = textBox15.Text;
                                        string work = MyString.Remove(Convert.ToInt32(me), 1);
                                        textBox1.Text = work;


                                        //encodes 6x6x6 matrix
                                        //inserts in a spot on a string.
                                        String original = textBox1.Text;
                                        String modified = original.Insert(Convert.ToInt32(me), nn);
                                        textBox1.Text = modified;

                                    }


                                    if (yy == 4)
                                    {

                                        int me = xx + 18 + 36 + 36 + 36 + 36;






                                        string test = Convert.ToString(me);
                                        textBox19.Text += test + ".";



                                        //Plaintext code
                                        //Gets a char from string.
                                        string n = textBox2.Text;

                                        string nn = n.Substring(0, 1);

                                        //6x6x6 matrix
                                        //Removes a spot from string.
                                        string MyString = textBox15.Text;
                                        string work = MyString.Remove(Convert.ToInt32(me), 1);
                                        textBox1.Text = work;


                                        //encodes 6x6x6 matrix
                                        //inserts in a spot on a string.
                                        String original = textBox1.Text;
                                        String modified = original.Insert(Convert.ToInt32(me), nn);
                                        textBox1.Text = modified;

                                    }



                                    if (yy == 5)
                                    {

                                        int me = xx + 24 + 36 + 36 + 36 + 36;





                                        string test = Convert.ToString(me);
                                        textBox19.Text += test + ".";



                                        //Plaintext code
                                        //Gets a char from string.
                                        string n = textBox2.Text;

                                        string nn = n.Substring(0, 1);

                                        //6x6x6 matrix
                                        //Removes a spot from string.
                                        string MyString = textBox15.Text;
                                        string work = MyString.Remove(Convert.ToInt32(me), 1);
                                        textBox1.Text = work;


                                        //encodes 6x6x6 matrix
                                        //inserts in a spot on a string.
                                        String original = textBox1.Text;
                                        String modified = original.Insert(Convert.ToInt32(me), nn);
                                        textBox1.Text = modified;

                                    }


                                    if (yy == 6)
                                    {

                                        int me = xx + 30 + 36 + 36 + 36 + 36;





                                        string test = Convert.ToString(me);
                                        textBox19.Text += test + ".";



                                        //Plaintext code
                                        //Gets a char from string.
                                        string n = textBox2.Text;

                                        string nn = n.Substring(0, 1);

                                        //6x6x6 matrix
                                        //Removes a spot from string.
                                        string MyString = textBox15.Text;
                                        string work = MyString.Remove(Convert.ToInt32(me), 1);
                                        textBox1.Text = work;


                                        //encodes 6x6x6 matrix
                                        //inserts in a spot on a string.
                                        String original = textBox1.Text;
                                        String modified = original.Insert(Convert.ToInt32(me), nn);
                                        textBox1.Text = modified;

                                    }


                                    if (zz == 5)
                                    {



                                        if (yy == 1)
                                        {

                                            int me = xx + 36 + 36 + 36 + 36 + 36;





                                            string test = Convert.ToString(me);
                                            textBox19.Text += test + ".";



                                            //Plaintext code
                                            //Gets a char from string.
                                            string n = textBox2.Text;

                                            string nn = n.Substring(0, 1);

                                            //6x6x6 matrix
                                            //Removes a spot from string.
                                            string MyString = textBox15.Text;
                                            string work = MyString.Remove(Convert.ToInt32(me), 1);
                                            textBox1.Text = work;


                                            //encodes 6x6x6 matrix
                                            //inserts in a spot on a string.
                                            String original = textBox1.Text;
                                            String modified = original.Insert(Convert.ToInt32(me), nn);
                                            textBox1.Text = modified;

                                        }


                                        if (yy == 2)
                                        {

                                            int me = xx + 6 + 36 + 36 + 36 + 36 + 36;





                                            string test = Convert.ToString(me);
                                            textBox19.Text += test + ".";



                                            //Plaintext code
                                            //Gets a char from string.
                                            string n = textBox2.Text;

                                            string nn = n.Substring(0, 1);

                                            //6x6x6 matrix
                                            //Removes a spot from string.
                                            string MyString = textBox15.Text;
                                            string work = MyString.Remove(Convert.ToInt32(me), 1);
                                            textBox1.Text = work;


                                            //encodes 6x6x6 matrix
                                            //inserts in a spot on a string.
                                            String original = textBox1.Text;
                                            String modified = original.Insert(Convert.ToInt32(me), nn);
                                            textBox1.Text = modified;

                                        }



                                        if (yy == 3)
                                        {

                                            int me = xx + 12 + 36 + 36 + 36 + 36 + 36;





                                            string test = Convert.ToString(me);
                                            textBox19.Text += test + ".";



                                            //Plaintext code
                                            //Gets a char from string.
                                            string n = textBox2.Text;

                                            string nn = n.Substring(0, 1);

                                            //6x6x6 matrix
                                            //Removes a spot from string.
                                            string MyString = textBox15.Text;
                                            string work = MyString.Remove(Convert.ToInt32(me), 1);
                                            textBox1.Text = work;


                                            //encodes 6x6x6 matrix
                                            //inserts in a spot on a string.
                                            String original = textBox1.Text;
                                            String modified = original.Insert(Convert.ToInt32(me), nn);
                                            textBox1.Text = modified;

                                        }


                                        if (yy == 4)
                                        {

                                            int me = xx + 18 + 36 + 36 + 36 + 36 + 36;






                                            string test = Convert.ToString(me);
                                            textBox19.Text += test + ".";



                                            //Plaintext code
                                            //Gets a char from string.
                                            string n = textBox2.Text;

                                            string nn = n.Substring(0, 1);

                                            //6x6x6 matrix
                                            //Removes a spot from string.
                                            string MyString = textBox15.Text;
                                            string work = MyString.Remove(Convert.ToInt32(me), 1);
                                            textBox1.Text = work;


                                            //encodes 6x6x6 matrix
                                            //inserts in a spot on a string.
                                            String original = textBox1.Text;
                                            String modified = original.Insert(Convert.ToInt32(me), nn);
                                            textBox1.Text = modified;

                                        }



                                        if (yy == 5)
                                        {

                                            int me = xx + 24 + 36 + 36 + 36 + 36 + 36;





                                            string test = Convert.ToString(me);
                                            textBox19.Text += test + ".";



                                            //Plaintext code
                                            //Gets a char from string.
                                            string n = textBox2.Text;

                                            string nn = n.Substring(0, 1);

                                            //6x6x6 matrix
                                            //Removes a spot from string.
                                            string MyString = textBox15.Text;
                                            string work = MyString.Remove(Convert.ToInt32(me), 1);
                                            textBox1.Text = work;


                                            //encodes 6x6x6 matrix
                                            //inserts in a spot on a string.
                                            String original = textBox1.Text;
                                            String modified = original.Insert(Convert.ToInt32(me), nn);
                                            textBox1.Text = modified;

                                        }


                                        if (yy == 6)
                                        {

                                            int me = xx + 30 + 36 + 36 + 36 + 36;





                                            string test = Convert.ToString(me);
                                            textBox19.Text += test + ".";



                                            //Plaintext code
                                            //Gets a char from string.
                                            string n = textBox2.Text;

                                            string nn = n.Substring(0, 1);

                                            //6x6x6 matrix
                                            //Removes a spot from string.
                                            string MyString = textBox15.Text;
                                            string work = MyString.Remove(Convert.ToInt32(me), 1);
                                            textBox1.Text = work;


                                            //encodes 6x6x6 matrix
                                            //inserts in a spot on a string.
                                            String original = textBox1.Text;
                                            String modified = original.Insert(Convert.ToInt32(me), nn);
                                            textBox1.Text = modified;

                                        }

                                    }
                                }

                            }
                        }
                    }
                }
            }

        }
    }
}


                




            
    
