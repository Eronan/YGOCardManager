using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

public enum CardType
{
    Continuous = 0x20000,
    Counter = 0x100000,
    Effect = 0x20,
    Equip = 0x40000,
    Field = 0x80000,
    Flip = 0x200000,
    Fusion = 0x40,
    Monster = 1,
    Normal = 0x10,
    QuickPlay = 0x10000,
    Ritual = 0x80,
    Spell = 2,
    Spirit = 0x200,
    Synchro = 0x2000,
    Token = 0x4000,
    Toon = 0x400000,
    Trap = 4,
    TrapMonster = 0x100,
    Tuner = 0x1000,
    Union = 0x400,
    Xyz = 0x800000,
    Gemini = 0x800,
    Pendulum = 0x1000000,
    Rune = 0x10000000,
}

namespace YGOCardManager
{
    class Card
    {
        //Declare Variable Names
        public string _name = "";
        public string _description = "";
        public long _cID = 0;
        public long _alias = 0;
        public int _frmt = 0;
        public long _setcode = 0;

        public string _loadedImage = "";

        public long _type = 0;
        public int _level = 0;
        public int _lScale = 0;
        public int _rScale = 0;

        public long _race = 0;
        public long _attribute = 0;

        public int _atk = 0;
        public int _def = 0;

        public long _category = 0;
        public string[] _effDescription = new string[16];

        public Card()
        {

        }

        public Card(DataRow txtDr, DataRow dtaDr)
        {
            _cID = Convert.ToInt64(txtDr["id"]);
            _name = txtDr["name"].ToString();
            _description = txtDr["desc"].ToString();
            _alias = Convert.ToInt64(dtaDr["alias"]);
            _frmt = Convert.ToInt32(dtaDr["ot"]);
            _setcode = Convert.ToInt32(dtaDr["setcode"]);

            _loadedImage = _cID.ToString();

            _type = Convert.ToInt64(dtaDr["type"]);

            uint num = uint.Parse(dtaDr["level"].ToString());

            _level = (int)(num & 0xff);
            _lScale = (int)((num >> 0x18) & 0xff);
            _rScale = (int)((num >> 0x10) & 0xff);

            _race = Convert.ToInt64(dtaDr["race"]);
            _attribute = Convert.ToInt64(dtaDr["attribute"]);

            _atk = Convert.ToInt32(dtaDr["atk"]);
            _def = Convert.ToInt32(dtaDr["def"]);

            _category = Convert.ToInt64(dtaDr["category"]);

            for (int i = 1; i <= 16; i++)
            {
                _effDescription[i - 1] = txtDr["str" + i].ToString();
            }
        }

        public CardType[] GetCardTypes()
        {
            // Author: Damien Lawford AKA Buttys
            var typeArray = Enum.GetValues(typeof(CardType));
            return typeArray.Cast<CardType>().Where(type => ((_type & (int)type) != 0)).ToArray();
        }

        public void AddDescription(string newDesc)
        {
            for (int i = 0; i < 16; i++)
            {
                if (_effDescription[i] == null)
                {
                    _effDescription[i] = newDesc;
                    break;
                }
            }
        }

        public static string[] MoveDescriptions(string[] effectDescriptions, bool completeArray = true)
        {
            List<string> convDescription = effectDescriptions.ToList();

            if (completeArray)
            {
                string[] returnList = new string[16];

                int i = 0;
                foreach (string str in convDescription)
                {
                    if (str == "" || str == " " || str == null) continue;
                    returnList[i] = str;
                    i++;
                }

                return returnList;
            }
            else
            {
                convDescription.RemoveAll(x => x == "");
                return convDescription.ToArray();
            }
        }
    }
}

