namespace Classes2
{
    class Material
    {
        private readonly string name;
        private readonly double density;

        public string Name
        {
            get
            {
                return name;
            }
        }
        public double Density
        {
            get
            {
                return density;
            }                      
        }

        public Material()
        {

        }

        public Material(string name, double density)
        {
            this.name = name;
            this.density = density;
        }
       
        public override string ToString()
        {
            return (name + ";" + density + ";");
        }

    }
}
