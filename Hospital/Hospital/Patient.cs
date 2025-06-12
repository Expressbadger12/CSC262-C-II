namespace Hospital
{
    public class Patient
    {
        //private attributes
        private string name;
        private int id;
        private int height;
        private int weight;
        private DateTime admissionDate;
        //the ? allows the attribute to be null
        private DateTime? dischargeDate;
        private int age;
        private string notes;

        public string Name
        {
            get { return name; }
            set
            {
                //the name must not be an empty string
                if (value != "")
                {
                    name = value;
                }
            }
        }

        //the id is generated automatically when the obejct is created, we doent need a section. this content cannot be chanted
        public int Id
        {
            get { return id; }
        }

        public int Height
        {
            get { return height; }

            set
            {
                if (value > 0 && value < 180)
                {
                    height = value;
                }
            }
        }
        public int Weight
        {
            get { return weight; }

            set
            {
                if (value > 0)
                {
                    weight = value;
                }
            }
        }
        public int Age
        {
            get { return age; }

            set
            {
                if (value > 0 && value < 150)
                {
                    age = value;
                }
            }
        }
        public DateTime AdmissionDate
        {
            get { return admissionDate; }
        }

        public DateTime? DischargeDate
        {
            get { return dischargeDate; }
            set { dischargeDate = value; }
        }

        public string Notes
            {
            get {return notes;}
            set { notes = value; }
            }

        //public Patient(string name, int id, int height, int weight)
        //{
        //    Name = name;
        //    this.id = id;
        //    Height = height;
        //    Weight = weight;
        //    this.admissionDate = admissionDate;
        //    DischargeDate = dischargeDate;
        //    Age = age;
        //    Notes = notes;
        //    Name = name;
        //    Height = height;
        //    Weight = weight;
        //    Age = age;
        //    DischargeDate = dischargeDate;
        //    Notes = notes;
        //}
    }

}
