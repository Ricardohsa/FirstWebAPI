using System;
using System.Reflection;

namespace RMMSA.WebAPI.Fornecedores.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}