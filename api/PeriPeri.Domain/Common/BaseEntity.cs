using System;
using System.Dynamic;
namespace PeriPeri.Domain.Common;

public class BaseEntity
{
	public Guid Id { get; set; }
	public DateTime CreatedOn { get; set; }
	public String CreatedBy { get; set; } = string.Empty;
	public DateTime UpdatedOn { get; set; }
	public String UpdatedBy { get; set; } = string.Empty;

	public void CreateEntity(string userName)
	{
		this.CreatedBy = userName;
		this.CreatedOn = DateTime.UtcNow;
	}
	
	public void UpdateEntity(string userName)
	{
		this.UpdatedBy = userName;
		this.UpdatedOn = DateTime.UtcNow;
	}
}

