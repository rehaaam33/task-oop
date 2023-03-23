using System;

public class myparty
{
   
    public string Name { get; set; }
    public string Location { get; set; }
    public int Numberofpeople { get; set; }
    public string Thepartyday { get; set; }
    public string Thetimepartystart { get; set; }
    public string Place { get; set; }
    public string Theme { get; set; }
    public string Thetimepartyend { get; set; }

        public static void Main(string[]args)
        {
        Console.WriteLine("THIS IS MY PARTY");
        }
        public myparty()
        {
        }

        public myparty(string name, string location, int numberofpeople, string thepartyday, string thetimepartystart, string place, string theme, string thetimepartyend)
        {
            Name = name;
            Location = location;
            Numberofpeople = numberofpeople;
            Thepartyday = thepartyday;
            Thetimepartystart = thetimepartystart;
            Place = place;
            Theme = theme;
            Thetimepartyend = thetimepartyend;
        }

        public myparty(string name, string location, int numberofpeople, string thepartyday)
        {
        Name = name;
        Location = location;
        Numberofpeople = numberofpeople;
        Thepartyday = thepartyday;
        }

        public myparty(string name, string thetimepartystart, string place, string theme, string thetimepartyend)
    
        {
            Name = name;
            Thetimepartystart = thetimepartystart;
            Place = place;
            Theme = theme;
            Thetimepartyend = thetimepartyend;
        }

        public myparty(string name, string location, int numberofpeople)
        {
            Name = name;
            Location = location;
            Numberofpeople = numberofpeople;
        }

        public myparty(string name, string thetimepartystart, string place)
        {
            Name = name;
            Thetimepartystart = thetimepartystart;
            Place = place;
        }

        //Methods
        public void AName(string name)
        {
            Name = name;
        }

        public void ALocation(string location)
        {
            Location = location;
        }

        public void ANumberofpeople(int numberofpeople)
        {
            Numberofpeople = numberofpeople;
;
        }

        public void AThepartyday(string thepartyday)

        {
            Thepartyday = thepartyday;
        }

        public void AThetimepartystart(string thetimepartystart)
        {
            Thetimepartystart = thetimepartystart;
        }

        public void UpdatePlace(string place)
        {
            Place = place;
        }

        public void ATheme(string theme)
        {
            Theme = theme;
        }

        public void AThetimepartyend(string endDate)
        {
            Thetimepartyend = Thetimepartyend;
        }
}



