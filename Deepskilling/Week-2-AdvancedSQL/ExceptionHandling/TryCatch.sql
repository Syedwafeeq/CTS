BEGIN TRY

    DECLARE @A INT = 10;
    DECLARE @B INT = 0;

    SELECT @A / @B;

END TRY

BEGIN CATCH

    SELECT
        ERROR_NUMBER() AS ErrorNumber,
        ERROR_MESSAGE() AS ErrorMessage,
        ERROR_LINE() AS ErrorLine;

END CATCH;
