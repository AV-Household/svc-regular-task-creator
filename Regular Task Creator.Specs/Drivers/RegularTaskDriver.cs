using Microsoft.AspNetCore.Hosting;
using TechTalk.SpecFlow.Infrastructure;
using static Regular_Task_Creator.Controllers.RegularTaskController;
namespace Regular_Task_Creator.Specs.Drivers;

public class RegularTaskDriver
{

    private readonly ISpecFlowOutputHelper _specFlowOutputHelper;

    public RegularTaskDriver(ISpecFlowOutputHelper specFlowOutputHelper)
    {
        _specFlowOutputHelper = specFlowOutputHelper;
    }

    private IWebHostBuilder driver;

    public async Task InitFamilyCollectionAsync(IEnumerable<FamilyMember> members)
    {
        // TODO Загрузка предоставленной семьи в БД
    }

    public async Task InitTemplatesCollectionAsync(IEnumerable<TaskTemplate> members)
    {
        // TODO Загрузка предоставленной семьи в БД
    }

    public async Task SetTokenAsync()
    {

    }

    public async Task AddTemplateAsync()
    {

    }

    public async Task EditTemplateAsync()
    {

    }

    public async Task DeleteTemplateAsync()
    {

    }

    public async Task<List<TaskTemplate>> GetTaskTemplatesAsync()
    {
        return null;
    }
}
