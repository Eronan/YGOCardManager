using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Data.SQLite;

namespace YGOCardManager
{
    public partial class MainForm : Form
    {
        Dictionary<int, string> c_SetCodes = new Dictionary<int, string>();
        List<int> m_cardRaces = new List<int>();
        List<int> m_cardAttributes = new List<int>();


        //Tables
        DataTable data;
        DataTable text;

        //Current Card
        Card currentCard = new Card();

        public MainForm(DataTable dtTable, DataTable txTable)
        {
            InitializeComponent();

            data = dtTable;
            text = txTable;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            list_Types.Items.AddRange(Enum.GetNames(typeof(CardType)));
            LoadSetCodesFromFile("Assets\\setname.txt");
            LoadCardRacesFromFile("Assets\\cardraces.txt");
            LoadCardAttributesFromFile("Assets\\cardattributes.txt");
        }


        private void textbox_Search_TextChanged(object sender, EventArgs e)
        {
            list_Search.Items.Clear();

            int findCode = 0;
            string findText = textbox_Search.Text;

            if (textbox_Search.TextLength > 3 && int.TryParse(findText, out findCode))
            {
                List<string> SearchedItems = new List<string>();
                foreach (DataRow dr in text.Rows)
                {
                    string name = dr["name"].ToString();
                    if (name.ToUpper().Contains(findText.ToUpper()) || dr["id"].ToString().Contains(findCode.ToString()))
                    {
                        SearchedItems.Add(name);
                    }
                }

                list_Search.Items.AddRange(SearchedItems.ToArray());
            }
            else if (textbox_Search.TextLength > 3)
            {
                List<string> SearchedItems = new List<string>();

                foreach (DataRow dr in text.Rows)
                {
                    string name = dr["name"].ToString();

                    if (name.ToUpper().Contains(findText.ToUpper()))
                    {
                        SearchedItems.Add(name);
                    }
                }

                list_Search.Items.AddRange(SearchedItems.ToArray());
            }
        }

        private void list_Search_DoubleClick(object sender, EventArgs e)
        {
            int index = list_Search.SelectedIndex;

            if (index >= 0)
            {
                string findText = textbox_Search.Text;
                int findCode = 0;

                if (textbox_Search.TextLength > 3 && int.TryParse(findText, out findCode))
                {
                    List<DataRow> searchedRows = new List<DataRow>();
                    foreach (DataRow dr in text.Rows)
                    {
                        string name = dr["name"].ToString();
                        if (name.ToUpper().Contains(findText.ToUpper()) || dr["id"].ToString().Contains(findCode.ToString()))
                        {
                            searchedRows.Add(dr);
                        }
                    }

                    DataRow textDr = searchedRows[index];
                    DataRow dataDr = data.Select("id='" + textDr["id"] + "'")[0];

                    currentCard = new Card(textDr, dataDr);
                    LoadCards(currentCard);
                }
                else if (textbox_Search.TextLength > 3)
                {
                    List<DataRow> searchedRows = new List<DataRow>();
                    foreach (DataRow dr in text.Rows)
                    {
                        string name = dr["name"].ToString();
                        if (name.ToUpper().Contains(findText.ToUpper()))
                        {
                            searchedRows.Add(dr);
                        }
                    }

                    DataRow textDr = searchedRows[index];
                    DataRow dataDr = data.Select("id='" + textDr["id"] + "'")[0];

                    currentCard = new Card(textDr, dataDr);
                    LoadCards(currentCard);
                }
            }
        }

        private void LoadSetCodesFromFile(string filedir)
        {
            //Code from Damien Lawford AKA Buttys
            c_SetCodes = new Dictionary<int, string>();
            List<string> setnames = new List<string>();

            if (!File.Exists(filedir))
                return;

            var reader = new StreamReader(File.OpenRead(filedir));
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (line == null) continue;
                string[] parts = line.Split(' ');
                if (parts.Length == 1) continue;
                string setname = line.Substring(parts[0].Length, line.Length - parts[0].Length).Trim();
                int setcode = Convert.ToInt32(parts[0], 16);

                if (!c_SetCodes.ContainsKey(setcode))
                {
                    setnames.Add(setname);
                    c_SetCodes.Add(setcode, setname);
                }
            }
            setnames.Sort();
            select_SetCode1.Items.AddRange(setnames.ToArray());
            select_SetCode2.Items.AddRange(setnames.ToArray());
            select_SetCode3.Items.AddRange(setnames.ToArray());
            select_SetCode4.Items.AddRange(setnames.ToArray());
        }

        private void LoadCardRacesFromFile(string filedir)
        {
            //Code from Damien Lawford AKA Buttys
            if (!File.Exists(filedir))
            {
                return;
            }

            var reader = new StreamReader(File.OpenRead(filedir));
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (line == null) continue;
                string[] parts = line.Split(' ');
                if (parts.Length == 1) continue;
                string racename = line.Substring(parts[0].Length, line.Length - parts[0].Length).Trim();

                select_Race.Items.Add(racename);
                m_cardRaces.Add(Convert.ToInt32(parts[0], 16));

            }
        }

        private void LoadCardAttributesFromFile(string filedir)
        {
            //Code from Damien Lawford AKA Buttys
            m_cardAttributes = new List<int>();

            if (!File.Exists(filedir))
            {
                return;
            }

            var reader = new StreamReader(File.OpenRead(filedir));
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (line == null) continue;
                string[] parts = line.Split(' ');
                if (parts.Length == 1) continue;
                string attributename = line.Substring(parts[0].Length, line.Length - parts[0].Length).Trim();

                select_Attribute.Items.Add(attributename);
                m_cardAttributes.Add(Convert.ToInt32(parts[0], 16));

            }
        }

        private void button_Pic_Click(object sender, EventArgs e)
        {
            //Code from Damien Lawford AKA Buttys
            currentCard._loadedImage = "";
            string imagepath = ImageResizer.OpenFileWindow("Set Image ", "", "Images|*.jpg;*.jpeg;*.png;");
            if (imagepath != null)
            {
                if (File.Exists(imagepath))
                {
                    using (var stream = new FileStream(imagepath, FileMode.Open, FileAccess.Read))
                    {
                        picBox_Image.Image = Image.FromStream(stream);
                    }
                    currentCard._loadedImage = imagepath;
                }
                else
                {
                    picBox_Image.Image = null;
                }
            }
        }

        private void LoadCards(Card toLoad)
        {
            //Match card with Form
            numUpDown_CardID.Value = toLoad._cID;
            numUpDown_Alias.Value = toLoad._alias;
            select_Format.SelectedIndex = toLoad._frmt - 1;

            numUpDown_Level.Value = toLoad._level;
            numUpDown_LeftScale.Value = toLoad._lScale;
            numUpDown_RightScale.Value = toLoad._rScale;
            numUpDown_ATK.Value = toLoad._atk;
            numUpDown_DEF.Value = toLoad._def;

            LoadCardImage(toLoad._cID);

            list_GameText.Items.Clear();
            list_GameText.Items.AddRange(Card.MoveDescriptions(toLoad._effDescription, false));

            //Text Information
            textbox_Name.Text = toLoad._name;
            textbox_Effect.Text = toLoad._description;

            //Code from Damien Lawford AKA Buttys

            long setcode = toLoad._setcode;

            //Get First Set Code
            if (c_SetCodes.ContainsKey((int)setcode)) select_SetCode1.SelectedItem = c_SetCodes[(int)setcode];
            else select_SetCode1.SelectedItem = c_SetCodes[0];

            setcode = toLoad._setcode >> 16 & 0xffff;

            //Get Second Set Code
            if (c_SetCodes.ContainsKey((int)setcode)) select_SetCode2.SelectedItem = c_SetCodes[(int)setcode];
            else select_SetCode2.SelectedItem = c_SetCodes[0];

            setcode = toLoad._setcode >> 32 & 0xffff;

            //Get Third Set Code
            if (c_SetCodes.ContainsKey((int)setcode)) select_SetCode3.SelectedItem = c_SetCodes[(int)setcode];
            else select_SetCode3.SelectedItem = c_SetCodes[0];

            setcode = toLoad._setcode >> 48 & 0xffff;

            //Get Fourth Set Code
            if (c_SetCodes.ContainsKey((int)setcode)) select_SetCode4.SelectedItem = c_SetCodes[(int)setcode];
            else select_SetCode4.SelectedItem = c_SetCodes[0];

            select_Race.SelectedIndex = -1;
            select_Attribute.SelectedIndex = -1;

            for (int i = 0; i < m_cardRaces.Count; i++)
            {
                if (m_cardRaces[i] == toLoad._race)
                {
                    select_Race.SelectedIndex = i;
                    break;
                }
            }

            for (int i = 0; i < m_cardAttributes.Count; i++)
            {
                if (m_cardAttributes[i] == toLoad._attribute)
                {
                    select_Attribute.SelectedIndex = i;
                    break;
                }
            }

            SetCardTypes(toLoad.GetCardTypes());
            SetCategoryCheckBoxes(toLoad._category);
            //
        }

        private void SetCardTypes(IEnumerable<CardType> types)
        {
            foreach (int i in list_Types.CheckedIndices)
            {
                list_Types.SetItemCheckState(i, CheckState.Unchecked);
            }

            //Code from Damien Lawford AKA Buttys

            foreach (var cardtype in types)
            {
                switch (cardtype)
                {
                    case CardType.Monster:
                        list_Types.SetItemCheckState(0, CheckState.Checked);
                        break;
                    case CardType.Spell:
                        list_Types.SetItemCheckState(1, CheckState.Checked);
                        break;
                    case CardType.Trap:
                        list_Types.SetItemCheckState(2, CheckState.Checked);
                        break;
                    case CardType.Normal:
                        list_Types.SetItemCheckState(3, CheckState.Checked);
                        break;
                    case CardType.Effect:
                        list_Types.SetItemCheckState(4, CheckState.Checked);
                        break;
                    case CardType.Fusion:
                        list_Types.SetItemCheckState(5, CheckState.Checked);
                        break;
                    case CardType.Ritual:
                        list_Types.SetItemCheckState(6, CheckState.Checked);
                        break;
                    case CardType.TrapMonster:
                        list_Types.SetItemCheckState(7, CheckState.Checked);
                        break;
                    case CardType.Spirit:
                        list_Types.SetItemCheckState(8, CheckState.Checked);
                        break;
                    case CardType.Union:
                        list_Types.SetItemCheckState(9, CheckState.Checked);
                        break;
                    case CardType.Gemini:
                        list_Types.SetItemCheckState(10, CheckState.Checked);
                        break;
                    case CardType.Tuner:
                        list_Types.SetItemCheckState(11, CheckState.Checked);
                        break;
                    case CardType.Synchro:
                        list_Types.SetItemCheckState(12, CheckState.Checked);
                        break;
                    case CardType.Token:
                        list_Types.SetItemCheckState(13, CheckState.Checked);
                        break;
                    case CardType.QuickPlay:
                        list_Types.SetItemCheckState(14, CheckState.Checked);
                        break;
                    case CardType.Continuous:
                        list_Types.SetItemCheckState(15, CheckState.Checked);
                        break;
                    case CardType.Equip:
                        list_Types.SetItemCheckState(16, CheckState.Checked);
                        break;
                    case CardType.Field:
                        list_Types.SetItemCheckState(17, CheckState.Checked);
                        break;
                    case CardType.Counter:
                        list_Types.SetItemCheckState(18, CheckState.Checked);
                        break;
                    case CardType.Flip:
                        list_Types.SetItemCheckState(19, CheckState.Checked);
                        break;
                    case CardType.Toon:
                        list_Types.SetItemCheckState(20, CheckState.Checked);
                        break;
                    case CardType.Xyz:
                        list_Types.SetItemCheckState(21, CheckState.Checked);
                        break;
                    case CardType.Pendulum:
                        list_Types.SetItemCheckState(22, CheckState.Checked);
                        break;
                    case CardType.Rune:
                        list_Types.SetItemCheckState(23, CheckState.Checked);
                        break;
                }
            }
        }

        private void LoadCardImage(long id)
        {
            //Code from Damien Lawford AKA Buttys
            if (File.Exists("pics//" + id + ".jpg"))
            {
                using (var stream = new FileStream("pics//" + id + ".jpg", FileMode.Open, FileAccess.Read))
                {
                    picBox_Image.Image = Image.FromStream(stream);
                }
            }
            else if (File.Exists("expansions//pics//" + id + ".jpg"))
            {
                using (var stream = new FileStream("expansions//pics//" + id + ".jpg", FileMode.Open, FileAccess.Read))
                {
                    picBox_Image.Image = Image.FromStream(stream);
                }
            }

            else

            {
                picBox_Image.Image = null;
            }
        }

        private void SetCategoryCheckBoxes(long categorynumber)
        {
            foreach (int i in list_Categories.CheckedIndices)
            {
                list_Categories.SetItemCheckState(i, CheckState.Unchecked);
            }


            // Author: Damien Lawford AKA Buttys
            int index = 0;
            int num;
            for (num = 1; index < list_Categories.Items.Count; num = num << 1)
            {
                list_Categories.SetItemCheckState(index,
                                                    (num & categorynumber) != 0L
                                                        ? CheckState.Checked
                                                        : CheckState.Unchecked);
                index++;
            }
        }

        private void button_AddText_Click(object sender, EventArgs e)
        {
            string input = textbox_GameText.Text;

            list_GameText.Items.Add(input);
            currentCard.AddDescription(input);
        }

        private void button_DeleteText_Click(object sender, EventArgs e)
        {
            int i = list_GameText.SelectedIndex;

            list_GameText.Items.RemoveAt(i);
            currentCard._effDescription[i] = "";
            currentCard._effDescription = Card.MoveDescriptions(currentCard._effDescription);
        }

        private void button_CreateScript_Click(object sender, EventArgs e)
        {
            if (currentCard._cID == 0 || currentCard._cID > 999999999)
            {
                MessageBox.Show("Error: Invalid Card ID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string file = "script\\c" + currentCard._cID + ".lua";

                if (File.Exists(file)) Process.Start(file);
                else
                {
                    string[] lines = { "--" + currentCard._name,
                                            "function c" + currentCard._cID + ".initial_effect(c)",
                                            string.Empty,
                                            "end" };
                    File.WriteAllLines(file, lines);
                    Process.Start(file);

                }
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            long id = currentCard._cID;

            if (id == 0 || id > 999999999)
            {
                MessageBox.Show("Error: Invalid Card ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            using (SQLiteConnection cnn = new SQLiteConnection("datasource=cards.cdb"))
            {
                try
                {
                    SQLiteCommand dtas = null;
                    SQLiteCommand txts = null;
                    string cmdstring = "";
                    string cmdstring2 = "";
                    if (data.Select("id='" + id + "'").Length > 0)
                    {
                        DialogResult dialog = MessageBox.Show("You sure you want to delete this card?", "Delete?", MessageBoxButtons.YesNo);
                        if (dialog == DialogResult.Yes)
                        {
                            dtas = new SQLiteCommand("select * from datas", cnn);
                            txts = new SQLiteCommand("select * from texts", cnn);

                            cmdstring = @"DELETE FROM datas WHERE id='" + id + "'";
                            cmdstring2 = @"DELETE FROM texts WHERE id='" + id + "'";

                            data.Select("id='" + id + "'")[0].Delete();
                            data.AcceptChanges();
                            text.Select("id='" + id + "'")[0].Delete();
                            text.AcceptChanges();

                            if (File.Exists("script\\c" + id + ".lua"))
                            {
                                File.Delete("script\\c" + id + ".lua");
                            }

                            dtas.CommandText = cmdstring;
                            txts.CommandText = cmdstring2;
                            cnn.Open();
                            int i = dtas.ExecuteNonQuery();
                            int j = txts.ExecuteNonQuery();
                            if (i == 1)
                            {
                                list_Search.Items.Remove(currentCard._name);
                                MessageBox.Show("Delete Successful!");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: Invalid Card ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                    MessageBox.Show("Deletion Unsuccessful");
                }
                finally
                {
                    if (cnn != null) cnn.Close();
                }
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            currentCard = new Card();

            numUpDown_CardID.Value = 0;
            numUpDown_Alias.Value = 0;
            select_Format.SelectedIndex = -1;
            select_SetCode1.SelectedIndex = 0;
            select_SetCode2.SelectedIndex = 0;
            select_SetCode3.SelectedIndex = 0;
            select_SetCode4.SelectedIndex = 0;
            numUpDown_Level.Value = 0;
            numUpDown_LeftScale.Value = 0;
            numUpDown_RightScale.Value = 0;
            select_Race.SelectedIndex = -1;
            select_Attribute.SelectedIndex = -1;

            numUpDown_ATK.Value = 0;
            numUpDown_DEF.Value = 0;

            textbox_Name.Text = "";
            textbox_Effect.Text = "";
            list_GameText.Items.Clear();

            foreach (int i in list_Types.CheckedIndices)
            {
                list_Types.SetItemCheckState(i, CheckState.Unchecked);
            }

            foreach (int i in list_Categories.CheckedIndices)
            {
                list_Categories.SetItemCheckState(i, CheckState.Unchecked);
            }

            picBox_Image.Image = null;
        }

        private void button_OpenScript_Click(object sender, EventArgs e)
        {
            string file = "script\\c" + currentCard._cID + ".lua";

            if (File.Exists(file)) Process.Start(file);
            else MessageBox.Show("File not found.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (numUpDown_CardID.Value > 999999999 || numUpDown_CardID.Value == 0)
            {
                MessageBox.Show("Invalid Card ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                currentCard._cID = (long)numUpDown_CardID.Value;
                currentCard._alias = (long)numUpDown_Alias.Value;

                currentCard._frmt = select_Format.SelectedIndex + 1;
                currentCard._setcode = GetSetCode();
                currentCard._level = (int)numUpDown_Level.Value;
                currentCard._lScale = (int)numUpDown_LeftScale.Value;
                currentCard._rScale = (int)numUpDown_RightScale.Value;

                currentCard._atk = (int)numUpDown_ATK.Value;
                currentCard._def = (int)numUpDown_DEF.Value;

                currentCard._name = textbox_Name.Text;
                currentCard._description = textbox_Effect.Text;

                // Author: Damien Lawford AKA Buttys
                currentCard._race = select_Race.SelectedItem == null ? 0 : (select_Race.SelectedItem == null ? 0 : m_cardRaces[select_Race.SelectedIndex]);

                currentCard._attribute = select_Attribute.SelectedItem == null ? 0 : (select_Attribute.SelectedItem == null ? 0 : m_cardAttributes[select_Attribute.SelectedIndex]);

                currentCard._type = GetTypeCode();
                currentCard._category = GetCategoryNumber();
                //


                using (SQLiteConnection cnn = new SQLiteConnection("datasource=cards.cdb"))
                {
                    try
                    {
                        SQLiteCommand dtas = null;
                        SQLiteCommand txts = null;
                        string cmdstring = "";
                        string cmdstring2 = "";
                        bool overwrite = false;

                        if (data.Select("id='" + currentCard._cID + "'").Length > 0) overwrite = true;

                        DialogResult dialog = DialogResult.Yes;
                        DataRow[] existRow = text.Select("id='" + currentCard._cID + "'");

                        if (overwrite && existRow.Length > 0)
                        {
                            if (existRow[0]["name"].ToString() != currentCard._name)
                            {
                                dialog = MessageBox.Show("A card with the same ID already exists.\nWould you like to overwrite the card?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            }
                        }

                        dtas = new SQLiteCommand("select * from datas", cnn);
                        txts = new SQLiteCommand("select * from texts", cnn);


                        if (overwrite && dialog == DialogResult.Yes)
                        {
                            
                            cmdstring = @"UPDATE datas SET " +
                                "id= @id, ot = @ot, alias= @alias, setcode= @setcode, type= @type, atk= @atk, def= @def, level= @level, race= @race, attribute= @attribute, category= @category WHERE id = @loadedid";
                            cmdstring2 = @"UPDATE texts SET " +
                                " id= @id,name= @name,desc= @des,str1= @str1,str2= @str2,str3= @str3,str4= @str4,str5= @str5,str6= @str6,str7= @str7,str8= @str8,str9= @str9,str10= @str10,str11= @str11,str12= @str12,str13= @str13,str14= @str14,str15= @str15,str16= @str16 WHERE id= @loadedid";

                            DataRow dtdr = data.Select("id='" + currentCard._cID + "'")[0];
                            DataRow txdr = text.Select("id='" + currentCard._cID + "'")[0];

                            dtdr["ot"] = currentCard._frmt;
                            dtdr["alias"] = currentCard._alias;
                            dtdr["setcode"] = currentCard._setcode;
                            dtdr["type"] = currentCard._type;
                            dtdr["atk"] = currentCard._atk;
                            dtdr["def"] = currentCard._def;
                            dtdr["level"] = currentCard._level;
                            dtdr["race"] = currentCard._race;
                            dtdr["attribute"] = currentCard._attribute;
                            dtdr["category"] = currentCard._category;

                            txdr["name"] = currentCard._name;
                            txdr["desc"] = currentCard._description;

                            for (int num = 1; num <= 16; num++)
                            {
                                txdr["str" + num] = currentCard._effDescription[num - 1];
                            }

                            data.AcceptChanges();
                            text.AcceptChanges();
                        }
                        else if (!overwrite)
                        {
                            cmdstring = @"INSERT INTO datas (id,ot,alias,setcode,type,atk,def,level,race,attribute,category)" +
                                " VALUES (@id, @ot, @alias, @setcode, @type, @atk, @def, @level, @race, @attribute, @category)";
                            cmdstring2 = "INSERT INTO texts (id,name,desc,str1,str2,str3,str4,str5,str6,str7,str8,str9,str10,str11,str12,str13,str14,str15,str16)" + 
                                " VALUES (@id,@name,@des,@str1,@str2,@str3,@str4,@str5,@str6,@str7,@str8,@str9,@str10,@str11,@str12,@str13,@str14,@str15,@str16)";

                            DataRow dtdr = data.NewRow();
                            DataRow txdr = text.NewRow();

                            dtdr["id"] = currentCard._cID;
                            dtdr["ot"] = currentCard._frmt;
                            dtdr["alias"] = currentCard._alias;
                            dtdr["setcode"] = currentCard._setcode;
                            dtdr["type"] = currentCard._type;
                            dtdr["atk"] = currentCard._atk;
                            dtdr["def"] = currentCard._def;
                            dtdr["level"] = currentCard._level;
                            dtdr["race"] = currentCard._race;
                            dtdr["attribute"] = currentCard._attribute;
                            dtdr["category"] = currentCard._category;

                            txdr["id"] = currentCard._cID;
                            txdr["name"] = currentCard._name;
                            txdr["desc"] = currentCard._description;

                            for (int num = 1; num <= 16; num++)
                            {
                                txdr["str" + num] = currentCard._effDescription[num - 1];
                            }

                            data.Rows.Add(dtdr);
                            text.Rows.Add(txdr);
                        }

                        dtas.Parameters.Add(new SQLiteParameter("@loadedid", currentCard._cID));
                        txts.Parameters.Add(new SQLiteParameter("@loadedid", currentCard._cID));
                        dtas.Parameters.Add(new SQLiteParameter("@id", currentCard._cID));
                        txts.Parameters.Add(new SQLiteParameter("@id", currentCard._cID));
                        dtas.Parameters.Add(new SQLiteParameter("@ot", currentCard._frmt));
                        dtas.Parameters.Add(new SQLiteParameter("@alias", currentCard._alias));
                        dtas.Parameters.Add(new SQLiteParameter("@setcode", currentCard._setcode));
                        dtas.Parameters.Add(new SQLiteParameter("@type", currentCard._type));
                        dtas.Parameters.Add(new SQLiteParameter("@atk", currentCard._atk));
                        dtas.Parameters.Add(new SQLiteParameter("@def", currentCard._def));
                        dtas.Parameters.Add(new SQLiteParameter("@level", GetLevelCode()));
                        dtas.Parameters.Add(new SQLiteParameter("@race", currentCard._race));
                        dtas.Parameters.Add(new SQLiteParameter("@attribute", currentCard._attribute));
                        dtas.Parameters.Add(new SQLiteParameter("@category", currentCard._category));

                        txts.Parameters.Add(new SQLiteParameter("@name", currentCard._name));
                        txts.Parameters.Add(new SQLiteParameter("@des", currentCard._description));
                        txts.Parameters.Add(new SQLiteParameter("@str1", currentCard._effDescription[0]));
                        txts.Parameters.Add(new SQLiteParameter("@str2", currentCard._effDescription[1]));
                        txts.Parameters.Add(new SQLiteParameter("@str3", currentCard._effDescription[2]));
                        txts.Parameters.Add(new SQLiteParameter("@str4", currentCard._effDescription[3]));
                        txts.Parameters.Add(new SQLiteParameter("@str5", currentCard._effDescription[4]));
                        txts.Parameters.Add(new SQLiteParameter("@str6", currentCard._effDescription[5]));
                        txts.Parameters.Add(new SQLiteParameter("@str7", currentCard._effDescription[6]));
                        txts.Parameters.Add(new SQLiteParameter("@str8", currentCard._effDescription[7]));
                        txts.Parameters.Add(new SQLiteParameter("@str9", currentCard._effDescription[8]));
                        txts.Parameters.Add(new SQLiteParameter("@str10", currentCard._effDescription[9]));
                        txts.Parameters.Add(new SQLiteParameter("@str11", currentCard._effDescription[10]));
                        txts.Parameters.Add(new SQLiteParameter("@str12", currentCard._effDescription[11]));
                        txts.Parameters.Add(new SQLiteParameter("@str13", currentCard._effDescription[12]));
                        txts.Parameters.Add(new SQLiteParameter("@str14", currentCard._effDescription[13]));
                        txts.Parameters.Add(new SQLiteParameter("@str15", currentCard._effDescription[14]));
                        txts.Parameters.Add(new SQLiteParameter("@str16", currentCard._effDescription[15]));

                        dtas.CommandText = cmdstring;
                        txts.CommandText = cmdstring2;
                        cnn.Open();

                        int i = dtas.ExecuteNonQuery();
                        int j = txts.ExecuteNonQuery();

                        if (i + j == 2)
                        {
                            SaveImage(currentCard._cID);
                            MessageBox.Show("Save Successful!");
                        }

                    }
                    catch (Exception exc)
                    {
                        Console.WriteLine(exc.Message);
                        MessageBox.Show("Save Unsuccessful");
                    }
                    finally
                    {
                        if (cnn != null) cnn.Close();
                    }
                }
            }
        }

        private long GetSetCode()
        {
            // Author: Damien Lawford AKA Buttys
            MemoryStream m_stream = new MemoryStream();
            BinaryWriter m_writer = new BinaryWriter(m_stream);
            m_writer.Write((short)((select_SetCode1.SelectedIndex > 0) ? GetSetCodeFromString(select_SetCode1.SelectedItem.ToString()) : 0));
            m_writer.Write((short)((select_SetCode2.SelectedIndex > 0) ? GetSetCodeFromString(select_SetCode2.SelectedItem.ToString()) : 0));
            m_writer.Write((short)((select_SetCode3.SelectedIndex > 0) ? GetSetCodeFromString(select_SetCode3.SelectedItem.ToString()) : 0));
            m_writer.Write((short)((select_SetCode4.SelectedIndex > 0) ? GetSetCodeFromString(select_SetCode4.SelectedItem.ToString()) : 0));
            return BitConverter.ToInt64(m_stream.ToArray(), 0);
        }

        private int GetSetCodeFromString(string name)
        {
            // Author: Damien Lawford AKA Buttys
            foreach (var item in c_SetCodes)
                if (item.Value == name)
                    return item.Key;
            return 0;
        }

        private int GetTypeCode()
        {
            // Author: Damien Lawford AKA Buttys
            int code = 0;
            if (list_Types.GetItemCheckState(0) == CheckState.Checked)
                code += (int)CardType.Monster;
            if (list_Types.GetItemCheckState(1) == CheckState.Checked)
                code += (int)CardType.Spell;
            if (list_Types.GetItemCheckState(2) == CheckState.Checked)
                code += (int)CardType.Trap;
            if (list_Types.GetItemCheckState(3) == CheckState.Checked)
                code += (int)CardType.Normal;
            if (list_Types.GetItemCheckState(4) == CheckState.Checked)
                code += (int)CardType.Effect;
            if (list_Types.GetItemCheckState(5) == CheckState.Checked)
                code += (int)CardType.Fusion;
            if (list_Types.GetItemCheckState(6) == CheckState.Checked)
                code += (int)CardType.Ritual;
            if (list_Types.GetItemCheckState(7) == CheckState.Checked)
                code += (int)CardType.TrapMonster;
            if (list_Types.GetItemCheckState(8) == CheckState.Checked)
                code += (int)CardType.Spirit;
            if (list_Types.GetItemCheckState(9) == CheckState.Checked)
                code += (int)CardType.Union;
            if (list_Types.GetItemCheckState(10) == CheckState.Checked)
                code += (int)CardType.Gemini;
            if (list_Types.GetItemCheckState(11) == CheckState.Checked)
                code += (int)CardType.Tuner;
            if (list_Types.GetItemCheckState(12) == CheckState.Checked)
                code += (int)CardType.Synchro;
            if (list_Types.GetItemCheckState(13) == CheckState.Checked)
                code += (int)CardType.Token;
            if (list_Types.GetItemCheckState(14) == CheckState.Checked)
                code += (int)CardType.QuickPlay;
            if (list_Types.GetItemCheckState(15) == CheckState.Checked)
                code += (int)CardType.Continuous;
            if (list_Types.GetItemCheckState(16) == CheckState.Checked)
                code += (int)CardType.Equip;
            if (list_Types.GetItemCheckState(17) == CheckState.Checked)
                code += (int)CardType.Field;
            if (list_Types.GetItemCheckState(18) == CheckState.Checked)
                code += (int)CardType.Counter;
            if (list_Types.GetItemCheckState(19) == CheckState.Checked)
                code += (int)CardType.Flip;
            if (list_Types.GetItemCheckState(20) == CheckState.Checked)
                code += (int)CardType.Toon;
            if (list_Types.GetItemCheckState(21) == CheckState.Checked)
                code += (int)CardType.Xyz;
            if (list_Types.GetItemCheckState(22) == CheckState.Checked)
                code += (int)CardType.Pendulum;
            if (list_Types.GetItemCheckState(23) == CheckState.Checked)
                code += (int)CardType.Rune;
            return code;
        }

        private int GetCategoryNumber()
        {
            // Author: Damien Lawford AKA Buttys
            int selectedIndex = 0;
            int num2 = 1;
            int num3 = 0;
            while (num3 < list_Categories.Items.Count)
            {
                if (list_Categories.GetItemCheckState(num3) == CheckState.Checked)
                {
                    selectedIndex |= num2;
                }
                num3++;
                num2 = num2 << 1;
            }

            return selectedIndex;
        }

        private int GetLevelCode()
        {
            //Author: Damien Lawford AKA Buttys
            MemoryStream m_stream = new MemoryStream();
            BinaryWriter m_writer = new BinaryWriter(m_stream);
            m_writer.Write((byte)(currentCard._level));
            m_writer.Write((byte)0);
            m_writer.Write((byte)Int32.Parse(currentCard._rScale.ToString()));
            m_writer.Write((byte)Int32.Parse(currentCard._lScale.ToString()));
            return BitConverter.ToInt32(m_stream.ToArray(), 0);
        }

        public void SaveImage(long cardid)
        {
            //Author: Damien Lawford AKA Buttys
            if (currentCard._loadedImage != "")
            {
                // Save card image
                ImageResizer.SaveImage(picBox_Image.Image,
                        "pics\\" + cardid + ".jpg", 177, 254);
                //Save card thumbnail
                ImageResizer.SaveImage(picBox_Image.Image,
                        "pics\\thumbnail\\" + cardid + ".jpg", 44, 64);
            }
        }
    }
}
    