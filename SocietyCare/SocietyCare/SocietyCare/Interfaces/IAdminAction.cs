using SocietyCare.Contracts;
using System.Collections.Generic;

namespace SocietyCare.Interfaces
{
    public interface IAdminAction
    {
        bool AddDetail<T>(IList<T> flatDetail);
        bool RemoveDetail<T>(string id);
        bool UpdateDetail<T>(IList<T> societyDetail);

        IList<T> ViewDocuments<T>(string id);

        bool UploadDocument<T>(IList<T> documents);

        bool RemoveDocument<T>(IList<T> documents);
    }
}
