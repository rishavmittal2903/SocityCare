using SocietyCare.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocietyCare.Interfaces
{
    public interface IDocuments
    {
        bool UploadDocuments(Documents document);
        bool DeleteDocuments(Documents document);
        bool UpdateDocuments(Documents document);

    }
}
