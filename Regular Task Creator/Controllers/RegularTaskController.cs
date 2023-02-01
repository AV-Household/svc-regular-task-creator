using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using Regular_Task_Creator.Models;
using System.Linq;
using System.Xml.Linq;

namespace Regular_Task_Creator.Controllers;
[ApiController]
[Route("[controller]")]
public class RegularTaskController : ControllerBase
{
    private static List<FamilyMember> _familyMembers = new List<FamilyMember>();
    private static List<TaskTemplate> _templates = new List<TaskTemplate>();
    private static string _currentDay = "";
    private static string _userName = "";

    // GET
    [HttpGet("GetFamilyMember")]
    public IEnumerable<FamilyMember> GetFamilyMembers()
    {
        return _familyMembers;
    }

    [HttpGet("GetTaskTemplates")]
    public IEnumerable<TaskTemplate> GetTemplates()
    {
        return _templates;
    }

    [HttpGet("GetExistTemplate")]
    public bool GetExistTemplate(string name, [FromQuery] List<string> recreateDays, string description)
    {
        return _templates.Find(template => template.Name == name &&
                                           Enumerable.SequenceEqual(recreateDays, template.RecreateDays) &&
                                           template.Description == description) != null;
    }

    [HttpGet("GetCurrentDay")]
    public string GetCurrentDay()
    {
        return _currentDay;
    }
    // GET

    // POST
    [HttpPost("LogIn")]
    public void LogIn(string name) { _userName = name; }

    [HttpPost("PostFamilyMember")]
    public void PostFamilyMember(string Name, string Phone, string Email, bool isAdult)
    {
        _familyMembers.Add(new FamilyMember(
            Name,
            Phone,
            Email,
            isAdult
            ));
    }

    [HttpPost("PostTaskTemplate")]
    public void PostTaskTemplate(string name, [FromQuery] List<string> recreateDays, string description)
    {
        var userData = _familyMembers.Find(member => member.Name == _userName);
        if (userData == null)
            throw new Exception();

        if (userData.IsAdult && _templates.Find(oldtemplate => (oldtemplate.Description == description &&
                                               Enumerable.SequenceEqual(recreateDays, oldtemplate.RecreateDays) &&
                                               oldtemplate.Name == name)) == null)
        {
            _templates.Add(new TaskTemplate(
            _templates.Count + 1,
            name,
            recreateDays,
            description
            ));
        }
    }

    [HttpPost("PostFamilyMemberOverload")]
    public void PostFamilyMember(FamilyMember member)
    {
        _familyMembers.Add(member);
    }

    [HttpPost("PostTaskTemplateOverload")]
    public void PostTaskTemplate(TaskTemplate template)
    {
        var userData = _familyMembers.Find(member => member.Name == _userName);
        if (userData == null)
            throw new Exception();
        if (userData.IsAdult && _templates.Find(oldtemplate => (oldtemplate.Description == template.Description &&
                                               Enumerable.SequenceEqual(oldtemplate.RecreateDays, template.RecreateDays) &&
                                               oldtemplate.Name == template.Name)) == null)
        {
            _templates.Add(template);
        }
    }

    [HttpPost("PostListTemplates")]
    public void PostTaskTemplate(List<TaskTemplate> templates)
    {
        _templates = templates;
    }

    [HttpPost("PostListFamily")]
    public void PostFamilyMember(List<FamilyMember> familyMembers)
    {
        _familyMembers = familyMembers;
    }
    // POST

    // DELETE
    [HttpDelete("DeleteTaskTemplate/{Id}")]
    public void DeleteTaskTemplate(int Id)
    {
        var elem = _templates.Find(template => template.Id == Id);
        var userData = _familyMembers.Find(member => member.Name == _userName);
        if (userData == null)
            throw new Exception();
        if (elem != null && userData.IsAdult) { _templates.Remove(elem); }
    }
    // DELETE

    // EDIT
    [HttpPut("EditTaskTemplate")]
    public void PutTaskTemplate(int Id, string name,  [FromQuery]List<string> recreateDays, string description)
    {
        int index = _templates.FindIndex(template => template.Id == Id);
        var userData = _familyMembers.Find(member => member.Name == _userName);
        if (userData == null)
            throw new Exception();
        if (index >= 0 && userData.IsAdult) { _templates[index] = new TaskTemplate(Id, name, recreateDays, description); }
    }

    [HttpPut("{Day}")]
    public void PutCurrentDay(string Day)
    {
        _currentDay = Day;
    }
    // EDIT
}

