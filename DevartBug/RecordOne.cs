using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DevartBug
{
	[Table("record_one")]
    public class RecordOne
    {
		[Column("id")]
	    public int Id { get; set; }
		
	    [InverseProperty(nameof(RecordMany.RecordOne))]
	    public List<RecordMany> RecordManyList { get; set; }
    }
}
