using AddressBook.Dto;
using AddressBook.Dto.PubEnum;

namespace AddressBook.IBLL
{
    public interface IBase_UserManager
    {
        LoginEnum Login(LoginInputDto input, out EcdrpSite ecdrpSite);
    }
}
