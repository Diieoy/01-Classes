namespace Classes2
{
    class Subject
    {
        private string name;
        private Material material;
        private double volume;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        public Material Material
        {
            get
            {
                return material;
            }

            set
            {               
                material = value;
            }
        }
        public double Volume
        {
            get
            {
                return volume;
            }

            set
            {
                volume = value;
            }
        }

        public Subject()
        {

        }

        public Subject(string name, Material material, double volume)
        {
            this.name = name;
            this.material = material;
            this.volume = volume;
        }

        public double GetMass()
        {
            return (material.Density * volume);
        }

        public override string ToString()
        {
            return (name + ";" + material + volume + ";");
        }
    }
}
