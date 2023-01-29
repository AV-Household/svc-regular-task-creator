using FluentAssertions.Equivalency;
using System.Diagnostics.CodeAnalysis;
using Regular_Task_Creator.Specs.Drivers;
using static Regular_Task_Creator.Controllers.RegularTaskController;
using System.Linq;

namespace Regular_Task_Creator.Specs.StepDefinitions;

[Binding]
public sealed class RegularTaskStepDefinitions
{
    private Dictionary<string, (string Email, string Phone, bool IsAdult)> _givenFamilyMembers = new();
    private Dictionary<string, (string Descript, int RecreateTime)> _givenTaskTemplates = new();

    private List<TaskTemplate>? _taskTemplatesList = new List<TaskTemplate>();

    private readonly RegularTaskDriver _regularTaskDriver;

    public RegularTaskStepDefinitions(RegularTaskDriver regularTaskDriver)
    {
        _regularTaskDriver = regularTaskDriver;
    }

    [Given(@"семья из")]
    public async Task GivenFamily(Table FamilyTable)
    {
        _givenFamilyMembers = FamilyTable.Rows
           .ToDictionary(row => row["Name"].Trim(), row => (Email: row["Email"].Trim(), Phone: row["Phone"].Trim(), IsAdult: row["Adult"].Trim() == "да"));

        var members = _givenFamilyMembers
            .Select(givenMember => new FamilyMember(
                Guid.NewGuid(),
                1,
                givenMember.Key,
                givenMember.Value.Phone,
                givenMember.Value.Email,
                givenMember.Value.IsAdult
            ));
        await _regularTaskDriver.InitFamilyCollectionAsync(members);
    }

    [Given(@"список шаблонов из")]
    public async Task GivenTemplatesList(Table table)
    {
        _givenTaskTemplates = table.Rows
           .ToDictionary(row => row["Name"].Trim(), row => (Descript: row["Description"], RecreateTime: Convert.ToInt32(row["Recreate Time(в часах)"].Trim())));

        var members = _givenTaskTemplates
            .Select(givenTemplate => new TaskTemplate(
                givenTemplate.Key,
                givenTemplate.Value.Descript,
                givenTemplate.Value.RecreateTime
            ));
        await _regularTaskDriver.InitTemplatesCollectionAsync(members);
    }

    [Given(@"в систему вошел (.*)")]
    public async Task GivenLogIn(string name)
    {
        await _regularTaskDriver.SetTokenAsync();
    }

    [When(@"пользователь добавляет шаблон \((.*), \((.*)\), (.*)\)")]
    public async Task WhenUserAddTemplate(string name, int recreateDays, string discript)
    {
        await _regularTaskDriver.AddTemplateAsync();
    }

    [When(@"пользователь удаляет шаблон \((.*), \((.*)\), (.*)\)")]
    public async Task WhenUserDeleteTemplate(string name, int time, string discript)
    {
        await _regularTaskDriver.DeleteTemplateAsync();
    }

    [When(@"пользователь изменяет шаблон \((.*), \((.*)\), (.*)\) на шаблон \((.*), \((.*)\), (.*)\)")]
    public async Task WhenUserEditTemplate(string p0, int p1, string p2, string p3, int p4, string p5)
    {
        await _regularTaskDriver.EditTemplateAsync();
    }

    [When(@"пользователь получает список шаблонов")]
    public async void WhenUserGetTemplatesList()
    {
        _taskTemplatesList = await _regularTaskDriver.GetTaskTemplatesAsync();
    }

    [Then(@"количество шаблонов в списке (.*)")]
    public void ThenCountTemplates(int p0)
    {
        _taskTemplatesList.Should().HaveCount(p0);
    }

    [Then(@"создать задачу из шаблона")]
    public void ThenCreateTaskFromTemplate()
    {
        // Вызов сервиса создания задач
    }

    [Then(@"в списке есть шаблон \((.*), \((.*)\), (.*)\)")]
    public void ThenTemplateExist(string name, int p0, string p5)
    {
        _taskTemplatesList.Should().ContainSingle(taskTemplate => taskTemplate.Name == name);
    }

    [When(@"день совпадает")]
    public void WhenДеньСовпал()
    {
        // Не знаю как реализовать
    }

    [Then(@"количество задач в списке (.*)")]
    public void ThenКоличествоЗадачВСписке(int p0)
    {
        // Вызов сервиса создания задач
    }

}