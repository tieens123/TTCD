namespace lab04.Models
{
    public class DataLoal
    {
        public static List<People> _peoples = new List<People>()
        {
            new People()
            {
                Id = 0,
                Name = "Devmaster",
                Email = "devmaster.edu.vn",
                Phone = "0987654321",
                Address = "25 VŨ NGỌC PHAN",
                Avatar = "images/avatar/01.jpg",
                Birthday = Convert.ToDateTime("21/05/2123"),
                Bio = "devmaster",
                Gender = 0
            },
            new People()
            {
                Id = 1,
                Name = "Tien",
                Email = "tienhss2k3@gmail.com",
                Phone = "0383428834",
                Address = "unknow",
                Avatar = "images/avatar/02.jpg",
                Birthday = Convert.ToDateTime("21/05/2003"),
                Bio = "devmaster",
                Gender = 1
            },
            new People()
            {
                Id = 2,
                Name = "Linh",
                Email = "pttl2k32gmail.com",
                Phone = "0987654321",
                Address = "unknow",
                Avatar = "images/avatar/03.jpg",
                Birthday = Convert.ToDateTime("14/11/2003"),
                Bio = "devmaster",
                Gender = 2
            },
        };
        public static List<People> GetPeoples()
        {
            return _peoples;
        }
        public static People? GetPeopleById(int Id)
        {
            var people = _peoples.FirstOrDefault(x => x.Id == Id);
            return people;
        }

    }
}
