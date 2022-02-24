# Lệnh gen code

Thay chuỗi connection_string = ""

dotnet ef dbcontext scaffold "connection_string" Microsoft.EntityFrameworkCore.SqlServer -o Model -c "AABBContext"

-- cmd config
dotnet ef dbcontext scaffold "connection_string" Microsoft.EntityFrameworkCore.SqlServer -d 

-- cmd UPDATE MODEL 
dotnet ef dbcontext scaffold "connection_string" Microsoft.EntityFrameworkCore.SqlServer --force

-- in vs
Scaffold-DbContext "connection_string" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Model -Context "AABBContext" -DataAnnotations