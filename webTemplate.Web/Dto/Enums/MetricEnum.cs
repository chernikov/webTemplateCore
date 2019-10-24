using System.ComponentModel.DataAnnotations;

namespace webTemplate.Web.Dto.Enums
{
    //[JsonConverter(typeof(StringEnumConverter))]
    public enum MetricEnum
    {
        [Display(Name = "# [x,xxx.xx]")]
        Number = 0x01,
        [Display(Name = "%")]
        Percent = 0x02,

        [Display(Name = "Length [ft]'[inch]\"")]
        Length = 0x03,
        [Display(Name = "Length [in.x]\"")]
        LengthIn = 0x04,


        [Display(Name = "Time [hr]:[min]:[sec]")]
        TimeLong = 0x05,
        [Display(Name = "Time [min]:[sec]")]
        TimeMid = 0x06,
        [Display(Name = "Time [min]:[sec].[0]")]
        TimeShort = 0x07,
        [Display(Name = "Time [sec].[00]")]
        TimeShortest = 0x08,


        [Display(Name = "Weight [x,xxx lbs]")]
        Weight = 0x09,
        [Display(Name = "Weight [x,xxx lbs]")]
        WeightCore = 0x0A,
        [Display(Name = "Reps [x,xxx]")]
        Reps = 0x0B
    }
}
