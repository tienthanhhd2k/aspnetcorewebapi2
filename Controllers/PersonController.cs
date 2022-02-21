using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using webapi2.Services;
using webapi2.Models;
using System.Net;

namespace webapi2.Controllers;

[ApiController]
[Route("[controller]")]

public class PersonController : ControllerBase
{
    private readonly IPeople _person;

    public PersonController( IPeople person)
    {
        _person = person;
    }
    [HttpGet]
    public IEnumerable<PersonModel> GetAll()
    {
        return _person.GetAll();
    }
    [HttpPost]
    public HttpStatusCode  Add (PersonModel person)
    {
        _person.Add(person);
        return HttpStatusCode.OK;
    }
    [HttpPut]
    public HttpStatusCode Update (PersonModel person)
    {
        _person.Update(person);
        return HttpStatusCode.OK;
    }
    [HttpDelete]
    public HttpStatusCode Delete(int Id)
    {
        _person.Delete(Id);
        return HttpStatusCode.OK;
    }
    [HttpGet("FullName")]
       public List<PersonModel> GetFullName(string firstname,string lastname,string gender,string birthplace){
          
        return  _person.GetFullName(firstname, lastname,gender,birthplace);
       }
}