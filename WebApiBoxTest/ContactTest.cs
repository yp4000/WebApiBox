using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApiBusiness.Repository;
using Moq;
using WebApiEntities;

namespace WebApiBoxTest
{
    [TestClass]
    public class ContactTest
    {
        private Mock<IContactRepository> mockedContactRepository;
        private ContactDTO mockContactDTOAddRequest;
        private ContactDTO mockContactDTOAddResponse;

        [TestInitialize]
        public void TestInitialize()
        {
            mockedContactRepository = new Mock<IContactRepository>();
            mockContactDTOAddRequest = new ContactDTO();
            mockContactDTOAddResponse = new ContactDTO();
        }

        [TestMethod]
        public void AddOK()
        {
            mockContactDTOAddRequest = FakeObjectsForTest.mockedContactDTOAddRequest();
            mockContactDTOAddResponse = FakeObjectsForTest.mockedContactDTOAddResponseOK();
            InitializeMocks();
            var response = Add(mockContactDTOAddRequest);
            AssertsForTest.AssertResponseContactAddOk(response);
        }

        private void InitializeMocks()
        {
            mockedContactRepository.Setup(x => x.Add(It.IsAny<ContactDTO>()))
                .Returns(mockContactDTOAddResponse);
        }

        private ContactDTO Add(ContactDTO item)
        {
            var response = mockedContactRepository.Object.Add(item);
            return response;
        }
    }
}
