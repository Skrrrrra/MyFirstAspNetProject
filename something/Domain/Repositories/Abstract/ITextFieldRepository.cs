using something.Domain.Entities;
namespace something.Domain.Repositories.Abstract
{
    public interface ITextFieldRepository
    {
        IQueryable<TextField> GetTextFields();
        TextField GetTextField(Guid ID);
        TextField GetTextField(string CodeWord);
        void SaveTextField(TextField entity);
        void DeleteTextField(Guid ID);

    }
}
