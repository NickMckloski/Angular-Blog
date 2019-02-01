using Blog.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Services.Services
{
    public interface IGenericService<TEntityViewModel> where TEntityViewModel : EntityViewModel
    {
        IEnumerable<TEntityViewModel> GetAll();

        Task<TEntityViewModel> GetByIdAsync(Guid id);

        Task<Guid> CreateAsync(TEntityViewModel viewModel);

        Task UpdateAsync(TEntityViewModel viewModel);

        Task DeleteAsync(Guid id);
    }
}
