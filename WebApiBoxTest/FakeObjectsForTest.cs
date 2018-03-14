using WebApiEntities;

namespace WebApiBoxTest
{
    internal static class FakeObjectsForTest
    {

        public static ContactDTO mockedContactDTOAddRequest()
        {
            return new ContactDTO()
            {
                 Name = "Fake name"
                ,Age = 100
                ,Nickname = " fake100"
                ,Active = false
            };
        }

        public static ContactDTO mockedContactDTOAddResponseOK()
        {
            return new ContactDTO()
            {
                 ConctactId = 1
                ,Name = "Fake name"
                ,Age = 100
                ,Nickname = " fake100"
                ,Active = true
            };
        }

    }
}
