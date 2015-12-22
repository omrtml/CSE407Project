Use Library;
go

Create Procedure RetardCheck
AS

Declare @BorrowEndDate date = (Select CONVERT (date, endDate) from Borrow);
Declare @Today date = CONVERT (date, GETDATE());

IF (DATEDIFF(day,@BorrowEndDate,@today) = 3 AND (Select statusBOOL from Borrow Where DATEDIFF(day,@BorrowEndDate,@today) = 3) = 1)
Begin
Update Borrow
Set day3 = 1
Where DATEDIFF(day,@BorrowEndDate,@today) = 3;
end

IF (DATEDIFF(day,@BorrowEndDate,@today) = 0 AND (Select statusBOOL from Borrow Where DATEDIFF(day,@BorrowEndDate,@today) = 0) = 1)
Begin
Update Borrow
Set lastDay = 1 
Where DATEDIFF(day,@BorrowEndDate,@today) = 0;
END


IF (DATEDIFF(day,@BorrowEndDate,@today) = -1 AND (Select statusBOOL from Borrow Where DATEDIFF(day,@BorrowEndDate,@today) = 0) = 1)
Begin
Insert Into Blacklist (studentID,processNO,listedDATE)
Values ((Select studentID
			from Borrow 
				Where DATEDIFF(day,@BorrowEndDate,@today) = -1), (Select processNO
																		from Borrow 
																			Where DATEDIFF(day,@BorrowEndDate,@today) = -1), @Today)
End				