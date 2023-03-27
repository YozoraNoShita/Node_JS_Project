using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Protocols
{
    public class Packets
    {
        public class comon
        {
            public int cmd;
        }

        public class req_scores : comon
        {
            public string id;
            public int score;
        }

        public class res_scores : comon
        {
            public string message;
        }

        public class user
        {
            public string id;
            public int score;
        }

        public class res_scores_top3 : req_scores
        {
            public user[] result;
        }

        public class res_scores_id : res_scores
        {
            public user result;
        }
    }
}
