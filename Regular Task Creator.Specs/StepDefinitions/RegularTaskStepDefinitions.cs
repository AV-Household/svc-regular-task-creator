using FluentAssertions.Equivalency;
using Regular_Task_Creator.Controllers;
using System.Diagnostics.CodeAnalysis;
using Regular_Task_Creator.Models;
using System.Linq;
using TechTalk.SpecFlow;

namespace Regular_Task_Creator.Specs.StepDefinitions;

[Binding]
public sealed class RegularTaskStepDefinitions
{

    RegularTaskController _controller = new RegularTaskController();

    [Given(@"семья из")]
    public void GivenFamily(Table FamilyMembersTable)
    {
        List<FamilyMember> familymembers = new List<FamilyMember>();
        foreach (var row in FamilyMembersTable.Rows)
        {
            familymembers.Add(new FamilyMember(row[0], row[1], row[2], Convert.ToBoolean(row[3])));
        }
        _controller.PostFamilyMember(familymembers);
    }

    [Given(@"список шаблонов из")]
    public void GivenTemplatesList(Table TaskTemplatesTable)
    {
        List<TaskTemplate> tasktemplates = new List<TaskTemplate>();
        foreach (var row in TaskTemplatesTable.Rows) 
        {
            List<string> RecreateDaysList = new List<string>(row[2].Split(','));
            tasktemplates.Add(new TaskTemplate(Convert.ToInt32(row[0]), row[1], RecreateDaysList, row[3]));
        }
        _controller.PostTaskTemplate(tasktemplates);
    }

    [Given(@"в систему вошел (.*)")]
    public void GivenLogIn(string username)
    {
        _controller.LogIn(username);
    }

    [When(@"пользователь добавляет шаблон \((.*), \((.*)\), (.*)\)")]
    public void WhenUserAddTemplate(string name, string recreateDays, string discript)
    {
        List<string> RecreateDaysList = new List<string>(recreateDays.Split(','));
        _controller.PostTaskTemplate(name, RecreateDaysList, discript);
    }

    [When(@"пользователь удаляет шаблон с Id (.*)")]
    public void WhenUserDeleteTemplate(int templateId)
    {
        _controller.DeleteTaskTemplate(templateId);
    }

    [When(@"пользователь изменяет шаблон с Id (.*) на шаблон \((.*), \((.*)\), (.*)\)")]
    public void WhenUserEditTemplate(int p2, string p3, string p4, string p5)
    {
        List<string> RecreateDaysList = new List<string>(p4.Split(','));
        _controller.PutTaskTemplate(p2, p3, RecreateDaysList, p5);
    }

    [Then(@"количество шаблонов в списке (.*)")]
    public void ThenCountTemplates(int p0)
    {
         _controller.GetTemplates().Should().HaveCount(p0);
    } 

    [Then(@"в списке есть шаблон \((.*), \((.*)\), (.*)\)")]
    public void ThenTemplateExist(string name, string p0, string p5)
    {
        List<string> RecreateDaysList = new List<string>(p0.Split(','));
        _controller.GetExistTemplate(name, RecreateDaysList, p5);
    }

    [When(@"наступил (.*)")]
    public void WhenNewDayStart(string DayOfWeek)
    {
        _controller.PutCurrentDay(DayOfWeek);
    }

    [Then(@"создать задачу из шаблона с Id (.*)")]
    public void ThenCreateTaskFromTemplate(int Id)
    {
        TaskTemplate elem = _controller.GetTemplates().ToList().Find(template => template.Id == Id);
        if (elem == null) { throw new Exception(); }
        List<string> days = elem.RecreateDays;
        if (days.Contains(_controller.GetCurrentDay()))
            OtherServiceNamespace.OtherServiceClass.GetTaskFromTemplate(elem);
    }
}