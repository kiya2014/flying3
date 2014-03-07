using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Codeplex.Data;

namespace Flying3
{
    public partial class Form1 : Form
    {
        Boolean isStop = false;
        string ctx = "http://www.prpr.dmmgames.com/";

        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            setButtonStart();

            int itemId = 1;
            if (radioButton2.Checked)
            {
                itemId = 2;
            }

            string sessionId = textBox3.Text;
            string next = ctx + "Operations_Quest/next?sessionId=" + sessionId + "&format=json&chancetime=0";
            if (checkBox1.Checked)
            {
                next += "&radar=1";
            }
            string clearChoice = ctx + "Operations_Clearchancetime/choice?sessionId=" + sessionId + "&format=json&select=1";
            string pointChoice = ctx + "Operations_Pointchancetime/choice?sessionId=" + sessionId + "&format=json&select=1";
            string battle = ctx + "Operations_Quest/zako?sessionId=" + sessionId + "&format=json";
            string recover = ctx + "Item/use?sessionId=" + sessionId + "&itemId=" + itemId + "&format=json&quant=1";
            string uri = next;

            while (!isStop)
            {
                WebRequest req = WebRequest.Create(uri);
                WebResponse res = req.GetResponse();
                Stream st = res.GetResponseStream();
                StreamReader sr = new StreamReader(st, Encoding.GetEncoding("Shift_JIS"));
                var json = DynamicJson.Parse(sr.ReadToEnd());
                if (!json.IsDefined("contents"))
                {
                    textBox1.Text = "UNKNOWN ERROR";
                    sr.Close();
                    st.Close();
                    break;
                }
                var contents = json.contents;
                textBox1.Text = contents + "\r\n";

                if (contents.IsDefined("point"))
                {
                    textBox2.Text = ((int)contents.point).ToString();
                }
                if (contents.IsDefined("item"))
                {
                    textBox4.Text = ((int)contents.item.quant).ToString();
                }
                if (contents.IsDefined("quest") && contents.quest.IsDefined("radar"))
                {
                    if (contents.quest.radar is string)
                    {
                        textBox5.Text = contents.quest.radar;
                    }
                    else
                    {
                        textBox5.Text = ((int)contents.quest.radar).ToString();
                    }
                }
                if (!contents.IsDefined("player"))
                {
                    if (json.IsDefined("header") && json.header.IsDefined("error_msg") &&
                        (json.header.error_msg == "action_point" || json.header.error_msg == "Not Action Point"))
                    {
                        uri = recover;
                    }
                    else
                    {
                        if (json.IsDefined("header") && json.header.IsDefined("error_msg"))
                        {
                            textBox1.Text = json.header.error_msg;
                        }
                        else
                        {
                            textBox1.Text = "UNKNOWN ERROR";
                        }
                        sr.Close();
                        st.Close();
                        break;
                    }
                }
                else
                {
                    if (contents.IsDefined("floorClear"))
                    {
                        uri = clearChoice;
                    }
                    else if (contents.IsDefined("pointChance"))
                    {
                        uri = pointChoice;
                    }
                    else if (contents.IsDefined("itemList") && contents.player.battlePoint.value >= 3)
                    {
                        uri = battle;
                    }
                    else if (int.Parse(contents.player.actionPoint.value) >= 7)
                    {
                        uri = next;
                    }
                    else
                    {
                        uri = recover;
                    }
                }

                sr.Close();
                st.Close();
                await Task.Delay(300);
            }

            setButtonEnd();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isStop = true;
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            setButtonStart();

            string divide = "free";
            if (radioButton4.Checked)
            {
                divide = "rare";
            }
            else if (radioButton5.Checked)
            {
                divide = "pvpBox";
            }

            string sessionId = textBox3.Text;
            string nGacha = ctx + "Gacha/gacha?sessionId=" + sessionId + "&format=json&select=ticket&divide=" + divide;
            string nGachaChoice = ctx + "Gacha/choice?sessionId=" + sessionId + "&divide=" + divide + "&format=json&token=tokendummy&select=1";

            while (!isStop)
            {
                WebRequest req = WebRequest.Create(nGacha);
                WebResponse res = req.GetResponse();
                Stream st = res.GetResponseStream();
                StreamReader sr = new StreamReader(st, Encoding.GetEncoding("Shift_JIS"));
                var json = DynamicJson.Parse(sr.ReadToEnd());
                if (!json.IsDefined("contents"))
                {
                    textBox1.Text = "UNKNOWN ERROR";
                    sr.Close();
                    st.Close();
                    break;
                }
                var contents = json.contents;
                textBox1.Text = contents + "\r\n";

                if (!contents.IsDefined("player"))
                {
                    if (json.IsDefined("header") && json.header.IsDefined("error_msg"))
                    {
                        textBox1.Text = json.header.error_msg;
                    }
                    else if (json.IsDefined("header") && json.header.IsDefined("error"))
                    {
                        textBox1.Text = json.header.error;
                    }
                    else
                    {
                        textBox1.Text = "UNKNOWN ERROR";
                    }
                    sr.Close();
                    st.Close();
                    break;
                }

                sr.Close();
                st.Close();
                await Task.Delay(300);

                req = WebRequest.Create(nGachaChoice);
                res = req.GetResponse();
                st = res.GetResponseStream();
                sr = new StreamReader(st, Encoding.GetEncoding("Shift_JIS"));
                json = DynamicJson.Parse(sr.ReadToEnd());
                contents = json.contents;
                textBox1.Text = contents + "\r\n";

                sr.Close();
                st.Close();
                await Task.Delay(300);

            }

            setButtonEnd();
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            setButtonStart();

            int itemId = 1;
            if (radioButton2.Checked)
            {
                itemId = 2;
            }

            string sessionId = textBox3.Text;
            string next = ctx + "Quest/next?sessionId=" + sessionId + "&format=json&chancetime=0&id=0";
            string choice = ctx + "Chancetime/choice?sessionId=" + sessionId + "&format=json&select=1";
            string recover = ctx + "Item/use?sessionId=" + sessionId + "&itemId=" + itemId + "&format=json&quant=1";
            string uri = next;

            while (!isStop)
            {
                WebRequest req = WebRequest.Create(uri);
                WebResponse res = req.GetResponse();
                Stream st = res.GetResponseStream();
                StreamReader sr = new StreamReader(st, Encoding.GetEncoding("Shift_JIS"));
                var json = DynamicJson.Parse(sr.ReadToEnd());
                if (!json.IsDefined("contents"))
                {
                    textBox1.Text = "UNKNOWN ERROR";
                    sr.Close();
                    st.Close();
                    break;
                }
                var contents = json.contents;
                textBox1.Text = contents + "\r\n";

                if (contents.IsDefined("item"))
                {
                    textBox4.Text = ((int)contents.item.quant).ToString();
                }
                if (!contents.IsDefined("player"))
                {
                    if (json.IsDefined("header") && json.header.IsDefined("error_msg") &&
                        (json.header.error_msg == "action_point" || json.header.error_msg == "Not Action Point"))
                    {
                        uri = recover;
                    }
                    else
                    {
                        if (json.IsDefined("header") && json.header.IsDefined("error_msg"))
                        {
                            textBox1.Text = json.header.error_msg;
                        }
                        else
                        {
                            textBox1.Text = "UNKNOWN ERROR";
                        }
                        sr.Close();
                        st.Close();
                        break;
                    }
                }
                else
                {
                    if (contents.IsDefined("chance"))
                    {
                        uri = choice;
                    }
                    else
                    {
                        uri = next;
                    }
                }

                sr.Close();
                st.Close();
                await Task.Delay(300);
            }

            setButtonEnd();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private async void button6_Click(object sender, EventArgs e)
        {
            setButtonStart();

            string sessionId = textBox3.Text;
            string opponentPlayerId = "";
            string list = ctx + "Pvp_Top/list?sessionId=" + sessionId + "&typeId=3&rank=1&format=json";
            string set = ctx + "Pvp_Battle?sessionId=" + sessionId + "&format=json&opponentPlayerId=";
            string battle = ctx + "Pvp_Battle/battle?sessionId=" + sessionId + "&format=json&opponentPlayerId=";
            string uri = list;

            while (!isStop)
            {
                WebRequest req = WebRequest.Create(uri);
                WebResponse res = req.GetResponse();
                Stream st = res.GetResponseStream();
                StreamReader sr = new StreamReader(st, Encoding.GetEncoding("Shift_JIS"));
                var json = DynamicJson.Parse(sr.ReadToEnd());
                if (!json.IsDefined("contents"))
                {
                    textBox1.Text = "UNKNOWN ERROR";
                    sr.Close();
                    st.Close();
                    break;
                }
                var contents = json.contents;
                textBox1.Text = contents + "\r\n";

                if (!contents.IsDefined("player"))
                {
                    if (json.IsDefined("header") && json.header.IsDefined("error_msg"))
                    {
                        textBox1.Text = json.header.error_msg;
                    }
                    else
                    {
                        textBox1.Text = "UNKNOWN ERROR";
                    }
                    sr.Close();
                    st.Close();
                    break;
                }
                else
                {
                    if (contents.IsDefined("searchList"))
                    {
                        dynamic[] searchList = (dynamic[])contents.searchList;
                        if (searchList.Length > 0)
                        {
                            opponentPlayerId = searchList[0].playerId;
                            uri = set + opponentPlayerId;
                        }
                    }
                    else if (contents.IsDefined("result"))
                    {
                        uri = list;
                    }
                    else if (contents.IsDefined("playerHelp"))
                    {
                        string id = contents.playerHelp.info.type.id;
                        if (int.Parse(id) == 3)
                        {
                            uri = battle + opponentPlayerId;
                            textBox6.Text = contents.consecutiveWins;
                        }
                    }
                }

                sr.Close();
                st.Close();
                await Task.Delay(5000);
            }

            setButtonEnd();
        }

        private async void button7_Click(object sender, EventArgs e)
        {
            setButtonStart();

            int itemId = 1;
            if (radioButton2.Checked)
            {
                itemId = 2;
            }

            string sessionId = textBox3.Text;
            int biyakuLevel = 15;
            if (textBox7.Text != "")
            {
                int i = 0;
                if (int.TryParse(textBox7.Text, out i))
                {
                    biyakuLevel = i;
                }
            }
            string raidboss_battle_id = "";
            int attack_count = 0;
            string next = ctx + "Raidboss_Event-Quest/next?sessionId=" + sessionId + "&format=json&chancetime=0";
            string battle = ctx + "Raidboss_Raidboss/battle?sessionId=" + sessionId + "&format=json&battlePoint=1&raidboss%5Fbattle%5Fid=";
            string escape = ctx + "Raidboss_Raidboss/escape?sessionId=" + sessionId + "&format=json&raidboss%5Fbattle%5Fid=";
            string debilitate = ctx + "Raidboss_Raidboss/debilitate?sessionId=" + sessionId + "&format=json&raidboss%5Fbattle%5Fid=";
            string help = ctx + "Raidboss_Raidboss/help?sessionId=" + sessionId + "&format=json&raidboss%5Fbattle%5Fid=";
            string invite = ctx + "Raidboss_Raidboss/invite-request?sessionId=" + sessionId + "&format=json&helpMessageId=1";
            string recover = ctx + "Item/use?sessionId=" + sessionId + "&itemId=" + itemId + "&format=json&quant=1";
            string uri = next;

            while (!isStop)
            {
                WebRequest req = WebRequest.Create(uri);
                WebResponse res = req.GetResponse();
                Stream st = res.GetResponseStream();
                StreamReader sr = new StreamReader(st, Encoding.GetEncoding("Shift_JIS"));
                var json = DynamicJson.Parse(sr.ReadToEnd());
                if (!json.IsDefined("contents"))
                {
                    textBox1.Text = "UNKNOWN ERROR";
                    sr.Close();
                    st.Close();
                    break;
                }
                var contents = json.contents;
                textBox1.Text = contents + "\r\n";

                if (!contents.IsDefined("player"))
                {
                    if (json.IsDefined("header") && json.header.IsDefined("error_msg") &&
                        (json.header.error_msg == "action_point" || json.header.error_msg == "Not Action Point"))
                    {
                        uri = recover;
                    }
                    else
                    {
                        if (json.IsDefined("header") && json.header.IsDefined("error_msg"))
                        {
                            textBox1.Text = json.header.error_msg;
                        }
                        else
                        {
                            textBox1.Text = "UNKNOWN ERROR";
                        }
                        sr.Close();
                        st.Close();
                        break;
                    }
                }
                else
                {
                    if (contents.IsDefined("raidboss_battle_id"))
                    {
                        raidboss_battle_id = contents.raidboss_battle_id;
                        attack_count = 0;
                        int type = (int)contents.boss.type;
                        int level = 0;
                        if (contents.boss.level is string)
                        {
                            level = int.Parse(contents.boss.level);
                        }
                        else
                        {
                            level = (int)contents.boss.level;
                        }
                        if (type == 0 || level > 50)
                        {
                            uri = escape + raidboss_battle_id;
                        }
                        else
                        {
                            if (level < biyakuLevel)
                            {
                                uri = battle + raidboss_battle_id;
                            }
                            else
                            {
                                uri = debilitate + raidboss_battle_id;
                            }
                        }
                    }
                    else if (contents.IsDefined("raidbossStatus"))
                    {
                        int status = (int)contents.raidbossStatus.status;
                        if (status > 1)
                        {
                            raidboss_battle_id = "";
                            uri = next;
                            if (contents.raidbossStatus.IsDefined("waitCalculation"))
                            {
                                int wait = (int)contents.raidbossStatus.waitCalculation;
                                if (wait > 0)
                                {
                                    await Task.Delay(30000);
                                }
                            }
                        }
                        else
                        {
                            if (contents.IsDefined("boss"))
                            {
                                if (contents.boss.IsDefined("killFlag"))
                                {
                                    if (contents.boss.bossMasterId != null)
                                    {
                                        attack_count++;
                                        if (attack_count == 1)
                                        {
                                            uri = help + raidboss_battle_id;
                                        }
                                    }
                                    int killFlag = (int)contents.boss.killFlag;
                                    if (killFlag == 1)
                                    {
                                        raidboss_battle_id = "";
                                        uri = next;
                                    }
                                }
                                else
                                {
                                    uri = battle + raidboss_battle_id;
                                }
                            }
                            else
                            {
                                raidboss_battle_id = "";
                                uri = next;
                            }
                        }
                    }
                    else if (contents.IsDefined("helpList"))
                    {
                        uri = invite;
                        dynamic[] helpList = (dynamic[])contents.helpList;
                        int i = 0;
                        Array.Sort(helpList, (a, b) => (int)a.player.login - (int)b.player.login);
                        foreach (dynamic helpFriend in helpList)
                        {
                            if (i < 20)
                            {
                                uri = uri + "&friends%5B%5D=" + helpFriend.player.id;
                            }
                            else
                            {
                                break;
                            }
                            i++;
                        }
                        uri = uri + "&raidboss%5Fbattle%5Fid=" + raidboss_battle_id;
                    }
                    else if (contents.IsDefined("friends"))
                    {
                        uri = battle + raidboss_battle_id;
                    }
                    else if (raidboss_battle_id != "")
                    {
                        uri = battle + raidboss_battle_id;
                    }
                    else if (int.Parse(contents.player.actionPoint.value) >= 3)
                    {
                        uri = next;
                    }
                    else
                    {
                        uri = recover;
                    }
                }

                sr.Close();
                st.Close();
                await Task.Delay(2000);
            }

            setButtonEnd();
        }

        private void setButtonStart()
        {
            isStop = false;
            button1.Enabled = false;
            button3.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
        }

        private void setButtonEnd()
        {
            button1.Enabled = true;
            button3.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
        }

    }

}
