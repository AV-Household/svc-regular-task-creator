using System.Xml.Linq;
namespace Regular_Task_Creator.Models;

public record TaskTemplate
(
    int Id, 
    string Name,
    List<string> RecreateDays,
    string Description
);
