﻿using System.Data;

namespace ADOTabular
{
    public class ADOTabularParameter
    {
        
        public ADOTabularParameter(DataRow dr)
        {
            Name = dr["NAME"].ToString();
            Description = dr["DESCRIPTION"].ToString();
            Optional = bool.Parse(dr["OPTIONAL"].ToString());
            Repeatable = bool.Parse(dr["REAPEATABLE"].ToString());
            RepeatGroup = int.Parse(dr["REPEATGROUP"].ToString());
        }

        public ADOTabularParameter(string name, string description, bool optional, bool repeatable, int repeatGroup)
        {
            Name = name;
            Description = description;
            Optional = optional;
            Repeatable = repeatable;
            RepeatGroup = repeatGroup;
        }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public bool Optional { get; private set; }
        public bool Repeatable { get; private set; }
        public int RepeatGroup { get; private set; }
    }
}
