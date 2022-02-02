namespace VasuthalozatAdminApplication.Entities
{
    public class Foglalas : AbstractEntity
    {
        static int IdGenerator = 0;

        public int UserID { get; set; }
        public int RailwayID { get; set; }
        public virtual User User { get; set; }
        public virtual Railway Railway { get; set; }

        public Foglalas(int userid, int railwayid)
        {
            ID = ++IdGenerator;
            UserID = userid;
            RailwayID = railwayid;
        }
        public Foglalas()
        {

        }
    }
}
