using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telamingo.Domain.Dtos.AddCountry;

public class EnvironmentalDto
{
    public int Id { get; set; }
    public int CountryId { get; set; }
    public int ReligiousIssues { get; set; }
    public int Immigration { get; set; }
    public int SocialRelationshipMatching { get; set; }

    public List<EnvironmentalLanguageInformationDto> environmentalLanguageInformation{ get; set; }
}
public class EnvironmentalLanguageInformationDto
{
    public int Id { get; set; }
    public int EnvironmentalInformationId { get; set; }
    public int LanguageId { get; set; }
    public double Rate { get; set; }
}
