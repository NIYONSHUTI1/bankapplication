namespace BankApp
{
    public class Customer
    {
        private string fname;
        private string lname;
        private string gender;

        public void setfname(string fname)
        {
            this.fname = this.fname;
        }

        public void setlname(string lname)
        {
            this.lname = this.lname;
        }

        public void setGender(string gender)
        {
            this.gender = this.gender;
        }

        public string getfname()
        {
            return fname;
        }
        
        public string getLasttName()
        {
            return lname;
        }

        public string getGender()
        {
            return gender;
        }

    }
}