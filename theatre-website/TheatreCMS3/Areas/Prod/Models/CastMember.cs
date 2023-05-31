using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheatreCMS3.Areas.Prod.Models
{
    public class CastMember
    {
        public int CastMemberId { get; set; }
        public string Name { get; set; }
        public int YearJoined { get; set; }
        public PositionEnum MainRole { get; set; }
        public string Bio { get; set; }
        //public byte Photo { get; set; }
        public bool CurrentMember { get; set; }
        public string Character { get; set; }
        public int CastYearLeft { get; set; }
        public int DebutYear { get; set; }



        //create enum for castmember positions
        public enum PositionEnum
        {
            Actor, //0
            Director, //1
            Technician, //2
            StageManager, //3
            Other, //4
        }
    }

}