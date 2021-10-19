using System;

namespace UnitTestAndDebug
{
    public class Person
    {
        public Person(string name, string id, string fecha)
        {
            this.Name = name;
            this.ID = id;
            this.FechaNacimiento = fecha;
        }
        
        private string fechaNacimiento;
        public string FechaNacimiento { 
            get
            {
                return this.fechaNacimiento;
            }
            set
            {
                string diat = value.Substring(0, 2);
                int dia = Int32.Parse(diat);
                string mest = value.Substring(3, 2);
                int mes = Int32.Parse(mest);
                string aniot = value.Substring(6, 4);
                int anio = Int32.Parse(aniot);



                if ( dia <=31 && dia >=1)
                {
                    if ( mes <=12 && mes >=1)
                    {
                        if ( anio <=2021 && anio >=1900)
                        {
                            this.fechaNacimiento = value;
                        }
                    }
                }
                else
                {
                    this.fechaNacimiento = "01-01-1900";
                }
            }
        }



        private string name;

        private string id;

        public string Name
        {
            get
            {
                return this.name;
            }
            
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
            }
        }
        public string ID
        {
            get
            {
                return this.id;
            }

            set
            {
                if (IdUtils.IdIsValid(value))
                {
                    this.id = value;
                }
            }
        }

        public void IntroduceYourself()
        {
            Console.WriteLine($"Soy {this.Name} y mi cédula es {this.ID}, naci el {this.FechaNacimiento}");
        }
    }
}
