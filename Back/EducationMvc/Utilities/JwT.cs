using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationMvc.Utilities
{
    public class JwT
    {
public string Key      {get;set;}
public string Iss    {get;set;}
public string Sub    {get;set;}
public string Aud    {get;set;}
public string Iat    {get;set;}
public string Exp    {get;set;}
public string Pro    {get;set;}
    }
}