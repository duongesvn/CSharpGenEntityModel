using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class AABBContext : DbContext
    {
        public AABBContext()
        {
        }

        public AABBContext(DbContextOptions<AABBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AlertSettingColor> AlertSettingColors { get; set; }
        public virtual DbSet<AspNetSession> AspNetSessions { get; set; }
        public virtual DbSet<AwbuildVersion> AwbuildVersions { get; set; }
        public virtual DbSet<BomcamSheet> BomcamSheets { get; set; }
        public virtual DbSet<BomcamSheetSetting> BomcamSheetSettings { get; set; }
        public virtual DbSet<BomcategoriesPlanMix> BomcategoriesPlanMixs { get; set; }
        public virtual DbSet<BomcategoriesPlanMixDetail> BomcategoriesPlanMixDetails { get; set; }
        public virtual DbSet<BomcategoriesTechnical> BomcategoriesTechnicals { get; set; }
        public virtual DbSet<Bomcategory> Bomcategories { get; set; }
        public virtual DbSet<BomcategoryHistory> BomcategoryHistories { get; set; }
        public virtual DbSet<BomcostNormHistory> BomcostNormHistories { get; set; }
        public virtual DbSet<BommaterialNorm> BommaterialNorms { get; set; }
        public virtual DbSet<BomworkOrderRouting> BomworkOrderRoutings { get; set; }
        public virtual DbSet<Bomworkpiece> Bomworkpieces { get; set; }
        public virtual DbSet<CastingCondition> CastingConditions { get; set; }
        public virtual DbSet<CastingConditionProcess> CastingConditionProcesses { get; set; }
        public virtual DbSet<CastingConditionsHistory> CastingConditionsHistories { get; set; }
        public virtual DbSet<CheckMachineDaily> CheckMachineDailies { get; set; }
        public virtual DbSet<CheckMachineDailyDetail> CheckMachineDailyDetails { get; set; }
        public virtual DbSet<ConsumableMaterial> ConsumableMaterials { get; set; }
        public virtual DbSet<CostNorm> CostNorms { get; set; }
        public virtual DbSet<CostNormsByLocation> CostNormsByLocations { get; set; }
        public virtual DbSet<CountryRegion> CountryRegions { get; set; }
        public virtual DbSet<DatabaseLog> DatabaseLogs { get; set; }
        public virtual DbSet<Device> Devices { get; set; }
        public virtual DbSet<DeviceProblem> DeviceProblems { get; set; }
        public virtual DbSet<DeviceProblemsComment> DeviceProblemsComments { get; set; }
        public virtual DbSet<DeviceProblemsCommentAttachment> DeviceProblemsCommentAttachments { get; set; }
        public virtual DbSet<DeviceProblemsDetail> DeviceProblemsDetails { get; set; }
        public virtual DbSet<ErrorClassification> ErrorClassifications { get; set; }
        public virtual DbSet<ErrorLog> ErrorLogs { get; set; }
        public virtual DbSet<FieldType> FieldTypes { get; set; }
        public virtual DbSet<Infrastructure> Infrastructures { get; set; }
        public virtual DbSet<InfrastructuresComment> InfrastructuresComments { get; set; }
        public virtual DbSet<JobCard> JobCards { get; set; }
        public virtual DbSet<JobCardsPqc> JobCardsPqcs { get; set; }
        public virtual DbSet<JobCardsQc> JobCardsQcs { get; set; }
        public virtual DbSet<JobCardsQcerror> JobCardsQcerrors { get; set; }
        public virtual DbSet<KhuonVecto> KhuonVectos { get; set; }
        public virtual DbSet<Knife> Knifes { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<LocationGroup> LocationGroups { get; set; }
        public virtual DbSet<LotNumber> LotNumbers { get; set; }
        public virtual DbSet<Machine> Machines { get; set; }
        public virtual DbSet<MachineError> MachineErrors { get; set; }
        public virtual DbSet<MachineType> MachineTypes { get; set; }
        public virtual DbSet<MachinesItem> MachinesItems { get; set; }
        public virtual DbSet<MaintenanceContent> MaintenanceContents { get; set; }
        public virtual DbSet<MaintenanceForm> MaintenanceForms { get; set; }
        public virtual DbSet<MaintenanceFormDetail> MaintenanceFormDetails { get; set; }
        public virtual DbSet<MaintenanceManagement> MaintenanceManagements { get; set; }
        public virtual DbSet<MaintenanceManagementAttachment> MaintenanceManagementAttachments { get; set; }
        public virtual DbSet<MaintenanceManagementComment> MaintenanceManagementComments { get; set; }
        public virtual DbSet<MaintenanceManagementDetail> MaintenanceManagementDetails { get; set; }
        public virtual DbSet<MaintenanceRequest> MaintenanceRequests { get; set; }
        public virtual DbSet<MaintenanceRequestComment> MaintenanceRequestComments { get; set; }
        public virtual DbSet<MaintenanceRequestDetail> MaintenanceRequestDetails { get; set; }
        public virtual DbSet<OriginWorkpiece> OriginWorkpieces { get; set; }
        public virtual DbSet<PlanCostLabor> PlanCostLabors { get; set; }
        public virtual DbSet<PlanMix> PlanMixes { get; set; }
        public virtual DbSet<PlanMixDetail> PlanMixDetails { get; set; }
        public virtual DbSet<PlanResource> PlanResources { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductCost> ProductCosts { get; set; }
        public virtual DbSet<ProductCostHistory> ProductCostHistories { get; set; }
        public virtual DbSet<ProductCostNorm> ProductCostNorms { get; set; }
        public virtual DbSet<ProductDescription> ProductDescriptions { get; set; }
        public virtual DbSet<ProductModel> ProductModels { get; set; }
        public virtual DbSet<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultures { get; set; }
        public virtual DbSet<ProductSpecification> ProductSpecifications { get; set; }
        public virtual DbSet<ProductionPlan> ProductionPlans { get; set; }
        public virtual DbSet<ProductionPlanDay> ProductionPlanDays { get; set; }
        public virtual DbSet<ProductionPlanDayHeader> ProductionPlanDayHeaders { get; set; }
        public virtual DbSet<ProductionPlansDetail> ProductionPlansDetails { get; set; }
        public virtual DbSet<RecommendInspection> RecommendInspections { get; set; }
        public virtual DbSet<RecommendInspectionComment> RecommendInspectionComments { get; set; }
        public virtual DbSet<RecommendInspectionDetail> RecommendInspectionDetails { get; set; }
        public virtual DbSet<RecommendInspectionProcess> RecommendInspectionProcesses { get; set; }
        public virtual DbSet<SaleBomcamSheet> SaleBomcamSheets { get; set; }
        public virtual DbSet<SaleBomcamSheetSetting> SaleBomcamSheetSettings { get; set; }
        public virtual DbSet<SaleBomcategory> SaleBomcategories { get; set; }
        public virtual DbSet<SaleBomcategoryHistory> SaleBomcategoryHistories { get; set; }
        public virtual DbSet<SaleBomcostNormHistory> SaleBomcostNormHistories { get; set; }
        public virtual DbSet<SaleBommaterialNorm> SaleBommaterialNorms { get; set; }
        public virtual DbSet<SaleBomworkOrderRouting> SaleBomworkOrderRoutings { get; set; }
        public virtual DbSet<SaleBomworkpiece> SaleBomworkpieces { get; set; }
        public virtual DbSet<SaleItemWaitingQuotation> SaleItemWaitingQuotations { get; set; }
        public virtual DbSet<SaleProductCostNorm> SaleProductCostNorms { get; set; }
        public virtual DbSet<ScrapReason> ScrapReasons { get; set; }
        public virtual DbSet<StateProvince> StateProvinces { get; set; }
        public virtual DbSet<Table1hatest> Table1hatests { get; set; }
        public virtual DbSet<TempPatron> TempPatrons { get; set; }
        public virtual DbSet<TypeOfProduction> TypeOfProductions { get; set; }
        public virtual DbSet<VAdditionalContactInfo> VAdditionalContactInfos { get; set; }
        public virtual DbSet<VEmployee> VEmployees { get; set; }
        public virtual DbSet<VEmployeeDepartment> VEmployeeDepartments { get; set; }
        public virtual DbSet<VEmployeeDepartmentHistory> VEmployeeDepartmentHistories { get; set; }
        public virtual DbSet<VIndividualCustomer> VIndividualCustomers { get; set; }
        public virtual DbSet<VJobCandidate> VJobCandidates { get; set; }
        public virtual DbSet<VJobCandidateEducation> VJobCandidateEducations { get; set; }
        public virtual DbSet<VJobCandidateEmployment> VJobCandidateEmployments { get; set; }
        public virtual DbSet<VPersonDemographic> VPersonDemographics { get; set; }
        public virtual DbSet<VProductAndDescription> VProductAndDescriptions { get; set; }
        public virtual DbSet<VProductModelCatalogDescription> VProductModelCatalogDescriptions { get; set; }
        public virtual DbSet<VProductModelInstruction> VProductModelInstructions { get; set; }
        public virtual DbSet<VSalesPerson> VSalesPeople { get; set; }
        public virtual DbSet<VSalesPersonSalesByFiscalYear> VSalesPersonSalesByFiscalYears { get; set; }
        public virtual DbSet<VStateProvinceCountryRegion> VStateProvinceCountryRegions { get; set; }
        public virtual DbSet<VStoreWithAddress> VStoreWithAddresses { get; set; }
        public virtual DbSet<VStoreWithContact> VStoreWithContacts { get; set; }
        public virtual DbSet<VStoreWithDemographic> VStoreWithDemographics { get; set; }
        public virtual DbSet<VVendorWithAddress> VVendorWithAddresses { get; set; }
        public virtual DbSet<VVendorWithContact> VVendorWithContacts { get; set; }
        public virtual DbSet<Workpiece> Workpieces { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=192.168.137.201;Database=VIETNHAT_PRO;uid=dev;password=esvn2020@;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AlertSettingColor>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationGuid, e.Alias, e.StatusId });

                entity.ToTable("AlertSettingColors", "Common");

                entity.HasComment("Danh mục cài đặt cảnh báo theo màu của trạng thái");

                entity.Property(e => e.OrganizationGuid).HasComment("Mã guid của đơn vị");

                entity.Property(e => e.Alias)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Mã định danh hay tên bảng áp dụng.");

                entity.Property(e => e.StatusId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("StatusID")
                    .HasComment("Mã trạng thái áp dụng");

                entity.Property(e => e.BackgroundColor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Mã màu nền mặc định");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasComment("Người tạo");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FontColor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Mã Màu chữ mặc định");

                entity.Property(e => e.IsActive).HasComment("= 1 Sử dụng, = 0 Ngừng sử dụng");

                entity.Property(e => e.IsBoldFont).HasComment("= 1 Kiểu chữ in đậm, = 0 Chữ không in đậm");

                entity.Property(e => e.IsItalicFont).HasComment("= 1 Kiểu chữ in nghiêng, = 0 Chữ không in nghiêng");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasComment("Người sửa");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RowGuid).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<AspNetSession>(entity =>
            {
                entity.Property(e => e.Id).HasMaxLength(449);

                entity.Property(e => e.Value).IsRequired();
            });

            modelBuilder.Entity<AwbuildVersion>(entity =>
            {
                entity.HasKey(e => e.SystemInformationId)
                    .HasName("PK_AWBuildVersion_SystemInformationID");

                entity.ToTable("AWBuildVersion");

                entity.HasComment("Current version number of the AdventureWorks 2016 sample database. ");

                entity.Property(e => e.SystemInformationId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SystemInformationID")
                    .HasComment("Primary key for AWBuildVersion records.");

                entity.Property(e => e.DatabaseVersion)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("Database Version")
                    .HasComment("Version number of the database in 9.yy.mm.dd.00 format.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Date and time the record was last updated.");

                entity.Property(e => e.VersionDate)
                    .HasColumnType("datetime")
                    .HasComment("Date and time the record was last updated.");
            });

            modelBuilder.Entity<BomcamSheet>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationGuid, e.Bomnumber, e.ProductItemId, e.PartItemId, e.LocationId, e.CamSheetId });

                entity.ToTable("BOMCamSheets", "Pro");

                entity.HasComment("Định mức nguyên công (lập trình CamSheet) của quy trình công nghệ có Lập trình sản xuất thành phẩm, bán thành phẩm.");

                entity.Property(e => e.OrganizationGuid).HasComment("Mã guid của đơn vị");

                entity.Property(e => e.Bomnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BOMNumber")
                    .HasComment("Mã BOM");

                entity.Property(e => e.ProductItemId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ProductItemID")
                    .HasComment("Mã thành phẩm. Tham chiếu từ bảng [Inventory].[Items] với tính chất là P-Thành phẩm. Tự động điền = [BOMCategories].ItemID khi chọn BOMNumber  ");

                entity.Property(e => e.PartItemId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PartItemID")
                    .HasComment("Mã bán thành phẩm. Tham chiếu từ bảng [Inventory].[Items] với tính chất là B-Bán thành phẩm. Khi Loại Type khác 'B' thì lưu giá trị = rỗng");

                entity.Property(e => e.LocationId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("LocationID")
                    .HasComment("Mã quy trình công nghệ. Tham chiếu bảng Common.Locations.");

                entity.Property(e => e.CamSheetId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("CamSheetID")
                    .HasComment("Mã Camsheet.");

                entity.Property(e => e.ApprovedDate).HasColumnType("date");

                entity.Property(e => e.ApprovedName).HasMaxLength(250);

                entity.Property(e => e.BoworGuid).HasColumnName("BOWorGuid");

                entity.Property(e => e.CamSheetDate)
                    .HasColumnType("date")
                    .HasComment("Ngày bàn giao");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .HasComment("Mô tả, ghi chú khi cần");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID")
                    .HasComment("Mã nhân viên Lập trình. Tham chiếu bảng ES_HR.[HR].[Employees]");

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(50)
                    .HasComment("Tên nhân viên lập trình");

                entity.Property(e => e.MachineTime)
                    .HasColumnType("numeric(18, 2)")
                    .HasComment("Machine Time");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Ngày và thời gian bản ghi được cập nhật.");

                entity.Property(e => e.OrderPlanId)
                    .HasMaxLength(150)
                    .HasColumnName("OrderPlanID")
                    .HasComment("Số kế hoạch tổng");

                entity.Property(e => e.OriginId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("OriginID")
                    .HasComment("Mã gốc phôi. Tham chiếu bảng [Common].[OriginWorkpieces]");

                entity.Property(e => e.RowGuid)
                    .HasDefaultValueSql("(newid())")
                    .HasComment("Mã guid tự sinh của bảng");

                entity.Property(e => e.SetupTime)
                    .HasColumnType("numeric(18, 2)")
                    .HasComment("Setup Time");

                entity.Property(e => e.SortOrder).HasComment("Thứ tự sắp xếp nếu có");

                entity.Property(e => e.UrlImage).HasMaxLength(250);

                entity.Property(e => e.WorkpieceQuantity)
                    .HasColumnType("numeric(18, 2)")
                    .HasComment("SP/Phôi");

                entity.HasOne(d => d.BomworkOrderRouting)
                    .WithMany(p => p.BomcamSheets)
                    .HasForeignKey(d => new { d.OrganizationGuid, d.Bomnumber, d.ProductItemId, d.PartItemId, d.LocationId })
                    .HasConstraintName("FK_BOMCamSheets_BOMWorkOrderRoutings");
            });

            modelBuilder.Entity<BomcamSheetSetting>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationGuid, e.Bomnumber, e.ProductItemId, e.PartItemId, e.LocationId, e.CamSheetId, e.KnifeId });

                entity.ToTable("BOMCamSheetSettings", "Pro");

                entity.HasComment("Thông số cài đặt dao của Nguyên công (CamSheets)");

                entity.Property(e => e.OrganizationGuid).HasComment("Mã guid của đơn vị");

                entity.Property(e => e.Bomnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BOMNumber")
                    .HasComment("Mã BOM");

                entity.Property(e => e.ProductItemId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ProductItemID")
                    .HasComment("Mã thành phẩm. Tham chiếu từ bảng [Inventory].[Items] với tính chất là P-Thành phẩm. Tự động điền = [BOMCategories].ItemID khi chọn BOMNumber  ");

                entity.Property(e => e.PartItemId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PartItemID")
                    .HasComment("Mã bán thành phẩm. Tham chiếu từ bảng [Inventory].[Items] với tính chất là B-Bán thành phẩm. Khi Loại Type khác 'B' thì lưu giá trị = rỗng");

                entity.Property(e => e.LocationId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("LocationID")
                    .HasComment("Mã quy trình công nghệ. Tham chiếu bảng Common.Locations.");

                entity.Property(e => e.CamSheetId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("CamSheetID");

                entity.Property(e => e.KnifeId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("KnifeID")
                    .HasComment("Mã Dao");

                entity.Property(e => e.CamSheetGuid).HasComment("Mã guid tham chiếu bảng [Pro].[BOMCamSheets]");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Depth)
                    .HasColumnType("numeric(18, 3)")
                    .HasComment("Chiều sâu");

                entity.Property(e => e.Length)
                    .HasColumnType("numeric(18, 3)")
                    .HasComment("Chiều dài");

                entity.Property(e => e.MachineTime).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Ngày và thời gian bản ghi được cập nhật.");

                entity.Property(e => e.Phi)
                    .HasColumnType("numeric(18, 3)")
                    .HasComment("Đơn vị đo Phi(Ø)");

                entity.Property(e => e.RowGuid)
                    .HasDefaultValueSql("(newid())")
                    .HasComment("Mã guid tự sinh của bảng");

                entity.Property(e => e.SetupTime).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Speed).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.StepProcess).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Width)
                    .HasColumnType("numeric(18, 3)")
                    .HasComment("Chiều rộng");

                entity.HasOne(d => d.BomcamSheet)
                    .WithMany(p => p.BomcamSheetSettings)
                    .HasForeignKey(d => new { d.OrganizationGuid, d.Bomnumber, d.ProductItemId, d.PartItemId, d.LocationId, d.CamSheetId })
                    .HasConstraintName("FK_BOMCamSheetSettings_BOMCamSheets");
            });

            modelBuilder.Entity<BomcategoriesPlanMix>(entity =>
            {
                entity.HasKey(e => e.RowGuid);

                entity.ToTable("BOMCategoriesPlanMixs", "Pro");

                entity.HasComment("Bảng phương án trộn gắn với mã BOM");

                entity.Property(e => e.RowGuid)
                    .HasDefaultValueSql("(newid())")
                    .HasComment("Mã guid tự tăng");

                entity.Property(e => e.Bomnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BOMNumber")
                    .HasComment("Mã bom");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasComment("Người tạo");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasComment("Ngày tạo");

                entity.Property(e => e.IsActive).HasComment("Trạng thái");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasComment("Người sửa");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasComment("Ngày sửa");

                entity.Property(e => e.OrganizationGuid).HasComment("Mã đơn vị");

                entity.Property(e => e.PartItemId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PartItemID")
                    .HasComment("Mã bán thành phẩm");

                entity.Property(e => e.PlanMixCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Mã phương án trộn");

                entity.Property(e => e.PlanMixName)
                    .HasMaxLength(150)
                    .HasComment("Tên phương án trộn");

                entity.Property(e => e.Quantity)
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("KL bán thành phẩm");

                entity.HasOne(d => d.Bomcategory)
                    .WithMany(p => p.BomcategoriesPlanMixes)
                    .HasForeignKey(d => new { d.OrganizationGuid, d.Bomnumber })
                    .HasConstraintName("FK_BOMCategoriesPlanMixs_BOMCategories");

                entity.HasOne(d => d.PlanMix)
                    .WithMany(p => p.BomcategoriesPlanMixes)
                    .HasForeignKey(d => new { d.OrganizationGuid, d.PlanMixCode })
                    .HasConstraintName("FK_BOMCategoriesPlanMixs_PlanMix");
            });

            modelBuilder.Entity<BomcategoriesPlanMixDetail>(entity =>
            {
                entity.HasKey(e => e.RowGuid);

                entity.ToTable("BOMCategoriesPlanMixDetails", "Pro");

                entity.HasComment("Định mức nhân công, chi phí nhân công");

                entity.Property(e => e.RowGuid)
                    .HasDefaultValueSql("(newid())")
                    .HasComment("Mã guid tự sinh");

                entity.Property(e => e.Amount)
                    .HasColumnType("numeric(18, 2)")
                    .HasComment("Tổng tiền");

                entity.Property(e => e.BomcategoriesPlanMixsGuid)
                    .HasColumnName("BOMCategoriesPlanMixsGuid")
                    .HasComment("Mã guid liên kết đến bàng Pro.BOMCategoriesPlanMixs (Định mức nhân công).");

                entity.Property(e => e.Bomnumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BOMNumber");

                entity.Property(e => e.Cost)
                    .HasColumnType("numeric(18, 2)")
                    .HasComment("CP Lương /Kg (Định mức nhân công). Chi phí sản phẩm (Chi phí nhân công)");

                entity.Property(e => e.IsActive).HasComment("Trạng thái sử dụng: 0 - Không sủ dụng. 1 - Sử dụng");

                entity.Property(e => e.Note)
                    .HasMaxLength(500)
                    .HasComment("Ghi chú");

                entity.Property(e => e.OrganizationGuid).HasComment("Mã đơn vị");

                entity.Property(e => e.PartItemId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PartItemID")
                    .HasComment("Mã bán thành phẩm: Dùng cho chi phí nhân công");

                entity.Property(e => e.PlanMixCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Mã phương án trộn");

                entity.Property(e => e.PlanMixName)
                    .HasMaxLength(250)
                    .HasComment("Tên phương án trộn");

                entity.Property(e => e.Quantity)
                    .HasColumnType("numeric(18, 2)")
                    .HasComment("Tổng KL trộn (kg) (Định mức nhân công). Sản lượng định mức (Chi phí nhân công)");

                entity.Property(e => e.ShiftId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("Mã ca");

                entity.Property(e => e.ShiftName)
                    .HasMaxLength(50)
                    .HasComment("Tên ca");

                entity.Property(e => e.Type)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasComment("Loại chi phí: DM - định mức nhân công, CP - chi phí nhân công");

                entity.HasOne(d => d.BomcategoriesPlanMixsGu)
                    .WithMany(p => p.BomcategoriesPlanMixDetails)
                    .HasForeignKey(d => d.BomcategoriesPlanMixsGuid)
                    .HasConstraintName("FK_BOMCategoriesPlanMixDetails_BOMCategoriesPlanMixs");
            });

            modelBuilder.Entity<BomcategoriesTechnical>(entity =>
            {
                entity.HasKey(e => e.RowGuid);

                entity.ToTable("BOMCategoriesTechnicals", "Pro");

                entity.HasComment("Bảng thông số kỹ thuật");

                entity.Property(e => e.RowGuid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Bomnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BOMNumber");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasComment("Người tạo");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Ngày tạo");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasComment("Người sửa cuối cùng");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Title1).HasMaxLength(250);

                entity.Property(e => e.Title2).HasMaxLength(250);

                entity.Property(e => e.Value1).HasMaxLength(250);

                entity.Property(e => e.Value2).HasMaxLength(250);

                entity.HasOne(d => d.Bomcategory)
                    .WithMany(p => p.BomcategoriesTechnicals)
                    .HasForeignKey(d => new { d.OrganizationGuid, d.Bomnumber })
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_BOMCategoriesTechnicals_BOMCategories");
            });

            modelBuilder.Entity<Bomcategory>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationGuid, e.Bomnumber });

                entity.ToTable("BOMCategories", "Pro");

                entity.HasComment("Danh sách BOM");

                entity.Property(e => e.OrganizationGuid).HasComment("Mã guid của đơn vị");

                entity.Property(e => e.Bomnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BOMNumber")
                    .HasComment("Mã BOM");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(100)
                    .HasComment("Người duyệt");

                entity.Property(e => e.ApprovedDate)
                    .HasColumnType("datetime")
                    .HasComment("Ngày duyệt");

                entity.Property(e => e.ApprovedStatus)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasComment("Trạng thái duyệt phiếu: N - Chưa duyệt. Y - Đã duyệt. NY - Không duyệt");

                entity.Property(e => e.BomnumberQuotation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BOMNumberQuotation")
                    .HasComment("Mã BOM được lập từ báo giá");

                entity.Property(e => e.Bomtype)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("BOMType")
                    .HasComment("CK - Bom cơ khí: SP - Bom sản phẩm");

                entity.Property(e => e.Cavity)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("Số cavity / Khuôn");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasComment("Người tạo");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Ngày tạo");

                entity.Property(e => e.CycleTime)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("Chu Kỳ làm ra 1 sản phẩm");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID")
                    .HasComment("Mã nhân viên bóc tách. Tham chiếu bảng [ES_HR].[HR].[Employees]");

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(50)
                    .HasComment("Tên nhân viên bóc tách.");

                entity.Property(e => e.FieldTypeId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("FieldTypeID")
                    .HasComment("Mã lĩnh vực sx thành phẩm. Tham chiếu bảng [Common].[FieldTypes]");

                entity.Property(e => e.ItemId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ItemID")
                    .HasComment("Mã Thành phẩm sản xuất (Mã nội bộ). Tham chiếu bảng ES_AM.Inventory.Items");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasComment("Người sửa cuối cùng");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ParentId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ParentID");

                entity.Property(e => e.RowGuid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.RunNumber)
                    .HasDefaultValueSql("((1))")
                    .HasComment("Thứ tự của phiên bản.");
            });

            modelBuilder.Entity<BomcategoryHistory>(entity =>
            {
                entity.HasKey(e => e.RowGuid);

                entity.ToTable("BOMCategoryHistories", "Pro");

                entity.HasComment("Lịch sử thay đổi BOM, phiên bản");

                entity.Property(e => e.RowGuid)
                    .HasDefaultValueSql("(newid())")
                    .HasComment("Mã guid tự sinh của bảng.");

                entity.Property(e => e.Bomnumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BOMNumber")
                    .HasComment("Mã BOM. Tham chiếu bảng Pro.BOMCategories");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasComment("Người tạo");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Ngày tạo");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasComment("Lý do thay đổi");

                entity.Property(e => e.OrganizationGuid).HasComment("Mã guid của đơn vị");

                entity.HasOne(d => d.Bomcategory)
                    .WithMany(p => p.BomcategoryHistories)
                    .HasForeignKey(d => new { d.OrganizationGuid, d.Bomnumber })
                    .HasConstraintName("FK_BOMCategoryHistories_BOMCategories");
            });

            modelBuilder.Entity<BomcostNormHistory>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationGuid, e.Bomnumber, e.ProductItemId, e.Date, e.CostType })
                    .HasName("PK_BOMCostNormLegders");

                entity.ToTable("BOMCostNormHistories", "Pro");

                entity.HasComment("Lịch sử giá thành sản xuất định mức");

                entity.Property(e => e.OrganizationGuid).HasComment("Mã guid của đơn vị");

                entity.Property(e => e.Bomnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BOMNumber")
                    .HasComment("Mã BOM. Tham chiếu bảng Pro.BOMCategories");

                entity.Property(e => e.ProductItemId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ProductItemID")
                    .HasComment("Mã thành phẩm. Tham chiếu từ bảng [Inventory].[Items] với tính chất là P-Thành phẩm. Tự động điền = [BOMCategories].ItemID khi chọn BOMNumber  ");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasComment("Ngày phát sinh/ ngày nhập chi phí");

                entity.Property(e => e.CostType)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasComment("Loại chi phí.  \r\n= G Chi phí gia công ngoài, \r\n= C Chi phí sx chung,\r\n= T Chi phí tài chính, \r\n= A Chi phí thất thoát, \r\n= V Chi phí nguyên liệu - vật liệu, \r\n= N Chi phí nhân công, \r\n= M - Chi phí sử dụng máy thi công, \r\n= K - Chi phí khác, \r\n= B - Chi phí bao bì");

                entity.Property(e => e.Amount)
                    .HasColumnType("numeric(20, 0)")
                    .HasComment("Số tiền phát sinh");

                entity.Property(e => e.AmountSurplus)
                    .HasColumnType("numeric(20, 0)")
                    .HasComment("Lũy kế tiền phát sinh");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.RowGuid)
                    .HasDefaultValueSql("(newid())")
                    .HasComment("Mã guid tự sinh của bảng");

                entity.HasOne(d => d.Bomcategory)
                    .WithMany(p => p.BomcostNormHistories)
                    .HasForeignKey(d => new { d.OrganizationGuid, d.Bomnumber })
                    .HasConstraintName("FK_BOMCostNormHistories_BOMCategories");
            });

            modelBuilder.Entity<BommaterialNorm>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationGuid, e.Bomnumber, e.ProductItemId, e.PartItemId, e.MaterialItemId });

                entity.ToTable("BOMMaterialNorms", "Pro");

                entity.HasComment("Định mức vật liệu, Bán thành phẩm");

                entity.Property(e => e.OrganizationGuid).HasComment("Mã guid của đơn vị");

                entity.Property(e => e.Bomnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BOMNumber")
                    .HasComment("Mã BOM. Tham chiếu bảng Pro.BOMCategories");

                entity.Property(e => e.ProductItemId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ProductItemID")
                    .HasComment("Mã thành phẩm. Tham chiếu từ bảng [Inventory].[Items] với tính chất là P-Thành phẩm. Tự động điền = [BOMCategories].ItemID khi chọn BOMNumber  ");

                entity.Property(e => e.PartItemId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PartItemID")
                    .HasComment("Mã bán thành phẩm. Tham chiếu từ bảng [Inventory].[Items] với tính chất là B-Bán thành phẩm. Khi Loại Type khác 'B' thì lưu giá trị = rỗng");

                entity.Property(e => e.MaterialItemId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MaterialItemID")
                    .HasComment("Mã vật tư, hàng hóa. Tham chiếu từ bảng [Inventory].[Items] với tính chất là V-Vật tư hàng hóa. Khi Loại Type khác 'V' thì lưu giá trị = rỗng");

                entity.Property(e => e.Amount)
                    .HasColumnType("numeric(20, 0)")
                    .HasComment("Thành tiền");

                entity.Property(e => e.ApecificGravity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BomworkpiecesGuid)
                    .HasColumnName("BOMWorkpiecesGuid")
                    .HasComment("Mã RowGuid của bảng BOMWorkpieces khi thêm NVL, Phổi để hiển thị dạng tree");

                entity.Property(e => e.Cavity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ChangeItemId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ChangeItemID")
                    .HasComment("Thay thế NVL");

                entity.Property(e => e.CodeType)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasComment("Mã loại code: PK - Phụ kiện. NVL - Nguyên vật liêu. CVT - Cavity/ set. NPL - Nguyên phụ liệu");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CycleTime).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasComment("Mô tả đặc điểm.");

                entity.Property(e => e.High).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IsActive)
                    .HasDefaultValueSql("((1))")
                    .HasComment("Trạng thái. = 1 Sử dụng, = 0 Ngừng sử dụng.");

                entity.Property(e => e.L1).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.L10).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.L11).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.L12).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.L13).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.L14).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.L15).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.L16).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.L17).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.L18).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.L19).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.L2).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.L20).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.L3).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.L4).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.L5).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.L6).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.L7).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.L8).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.L9).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Length).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ParentGuid).HasComment("Mã guid tham chiếu của mã thành phần cấp cha. Tham chiếu trực tiếp bảng hiện tại.");

                entity.Property(e => e.PercentLoss)
                    .HasColumnType("numeric(18, 3)")
                    .HasComment("Phần trăm hao hụt");

                entity.Property(e => e.Quantity)
                    .HasColumnType("numeric(20, 4)")
                    .HasComment("Số lượng vật tư.");

                entity.Property(e => e.QuantityLoss)
                    .HasColumnType("numeric(18, 3)")
                    .HasComment("Số lượng hao hụt. = % Hao hụt * Số lượng");

                entity.Property(e => e.RowGuid)
                    .HasDefaultValueSql("(newid())")
                    .HasComment("Mã guid tự sinh của bảng");

                entity.Property(e => e.Shape)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Size)
                    .HasMaxLength(400)
                    .HasComment("Kích thước");

                entity.Property(e => e.SizeId)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("SizeID");

                entity.Property(e => e.SizeOd)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("SizeOD");

                entity.Property(e => e.SortOrder).HasComment("Thứ tự sắp xếp");

                entity.Property(e => e.Type)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Loại. = B Bán thành phẩm, = V Vật tư dùng chung, = P Phôi sản xuất");

                entity.Property(e => e.UnitId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("UnitID")
                    .HasComment("Mã đơn vị tính. Nếu Loại định mức = V - Vật tư dùng chung thì lưu ĐVT của mã vật tư MaterialItemID. Nếu loại định mức = B thì lưu ĐVT của mã bán thành phẩm SemiFinishedItemID. ");

                entity.Property(e => e.UnitName).HasMaxLength(50);

                entity.Property(e => e.UnitPrice)
                    .HasColumnType("numeric(20, 3)")
                    .HasComment("Đơn giá (Ước tính nếu ko có trong kho)");

                entity.Property(e => e.Wide).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Bomcategory)
                    .WithMany(p => p.BommaterialNorms)
                    .HasForeignKey(d => new { d.OrganizationGuid, d.Bomnumber })
                    .HasConstraintName("FK_BOMMaterialNorms_BOMCategories");
            });

            modelBuilder.Entity<BomworkOrderRouting>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationGuid, e.Bomnumber, e.ProductItemId, e.PartItemId, e.LocationId });

                entity.ToTable("BOMWorkOrderRoutings", "Pro");

                entity.HasComment("Quy trình công nghệ sản xuất bán thành phẩm, thành phẩm");

                entity.Property(e => e.OrganizationGuid).HasComment("Mã guid của đơn vị");

                entity.Property(e => e.Bomnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BOMNumber")
                    .HasComment("Mã BOM. Tham chiếu bảng Pro.BOMCategories");

                entity.Property(e => e.ProductItemId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ProductItemID")
                    .HasComment("Mã thành phẩm. Tham chiếu từ bảng [Inventory].[Items] với tính chất là P-Thành phẩm. Tự động điền = [BOMCategories].ItemID khi chọn BOMNumber  ");

                entity.Property(e => e.PartItemId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PartItemID")
                    .HasComment("Mã bán thành phẩm. Tham chiếu từ bảng [Inventory].[Items] với tính chất là B-Bán thành phẩm. Khi Loại Type khác 'B' thì lưu giá trị = rỗng");

                entity.Property(e => e.LocationId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("LocationID")
                    .HasComment("Mã quy trình công nghệ. Tham chiếu bảng Common.Locations.");

                entity.Property(e => e.AuxiliaryMaterialCost)
                    .HasColumnType("numeric(20, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Chi phí vật liệu phụ");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CuttingCost)
                    .HasColumnType("numeric(20, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Chi phí dụng cụ cắt");

                entity.Property(e => e.CuttingToolId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("CuttingToolID")
                    .HasComment("Mã dụng cụ cắt");

                entity.Property(e => e.ElectricityCost)
                    .HasColumnType("numeric(20, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Chi phí điện");

                entity.Property(e => e.FactoryCost)
                    .HasColumnType("numeric(20, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Chi phí nhà xưởng");

                entity.Property(e => e.FixtureCost)
                    .HasColumnType("numeric(20, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Chi phí đồ gá");

                entity.Property(e => e.FixtureId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("FixtureID")
                    .HasComment("Mã đồ gá.");

                entity.Property(e => e.GroupLocationId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("GroupLocationID")
                    .HasComment("Mã khu vực vị trí của quy trình công nghệ. Tham chiếu bảng Common.GroupLocations, được lưu tự động khi chọn quy trình công nghệ.");

                entity.Property(e => e.InsuranceCost)
                    .HasColumnType("numeric(20, 0)")
                    .HasComment("Chi phí bảo hiểm công ty đóng");

                entity.Property(e => e.LaborCost)
                    .HasColumnType("numeric(20, 0)")
                    .HasComment("Chi phí lương nhân công");

                entity.Property(e => e.MachineCost)
                    .HasColumnType("numeric(20, 0)")
                    .HasComment("Chi phí máy.");

                entity.Property(e => e.MachineId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("MachineID")
                    .HasComment("Mã máy sử dụng dự kiến.");

                entity.Property(e => e.MeasuringCost)
                    .HasColumnType("numeric(20, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Chi phí dụng cụ đo");

                entity.Property(e => e.MeasuringToolId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("MeasuringToolID")
                    .HasComment("Mã dụng cụ đo");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NumberTask)
                    .HasDefaultValueSql("((1))")
                    .HasComment("Số nhân công dự kiến. Mặc định = 1 nếu ng dùng không nhập");

                entity.Property(e => e.ProductionTime)
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Thời gian sản xuất (đvt = Phút)");

                entity.Property(e => e.RowGuid)
                    .HasDefaultValueSql("(newid())")
                    .HasComment("Mã guid tự sinh của bảng");

                entity.Property(e => e.SetupTime)
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Thời gian cài đặt Setup (đvt = Phút)");

                entity.Property(e => e.SortOrder).HasComment("Thứ tự của quy trình trong quá trình sản xuất Thành phẩm, Bán thành phẩm");

                entity.Property(e => e.TotalCost)
                    .HasColumnType("numeric(38, 4)")
                    .HasComputedColumnSql("(((((((((isnull([LaborCost],(0))+isnull([InsuranceCost],(0)))+isnull([MachineCost],(0)))+isnull([ElectricityCost],(0)))+isnull([FactoryCost],(0)))+isnull([FixtureCost],(0)))+isnull([CuttingCost],(0)))+isnull([MeasuringCost],(0)))+isnull([AuxiliaryMaterialCost],(0)))*isnull([ProductionTime],(0)))", false)
                    .HasComment("Tổng chi phí");

                entity.Property(e => e.Type)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Loại. = P Quy trình công nghệ sản xuất thành phẩm, = B Quy trình công nghệ sản xuất bán thành phẩm");

                entity.HasOne(d => d.Bomcategory)
                    .WithMany(p => p.BomworkOrderRoutings)
                    .HasForeignKey(d => new { d.OrganizationGuid, d.Bomnumber })
                    .HasConstraintName("FK_BOMWorkOrderRoutings_BOMCategories");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.BomworkOrderRoutings)
                    .HasForeignKey(d => new { d.OrganizationGuid, d.LocationId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BOMWorkOrderRoutings_Locations");
            });

            modelBuilder.Entity<Bomworkpiece>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationGuid, e.Bomnumber, e.ProductItemId, e.PartItemId, e.LocationId, e.MaterialItemId, e.RowGuid });

                entity.ToTable("BOMWorkpieces", "Pro");

                entity.HasComment("Định mức NVL - Phôi dùng cho quy trình sản xuất bán thành phẩm (chỉ áp dụng quy trình có phôi)");

                entity.Property(e => e.OrganizationGuid).HasComment("Mã guid của đơn vị");

                entity.Property(e => e.Bomnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BOMNumber")
                    .HasComment("Mã BOM. Tham chiếu bảng Pro.BOMCategories");

                entity.Property(e => e.ProductItemId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ProductItemID")
                    .HasComment("Mã thành phẩm. Tham chiếu từ bảng [Inventory].[Items] với tính chất là P-Thành phẩm. Tự động điền = [BOMCategories].ItemID khi chọn BOMNumber  ");

                entity.Property(e => e.PartItemId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PartItemID")
                    .HasComment("Mã bán thành phẩm. Tham chiếu từ bảng [Inventory].[Items] với tính chất là B-Bán thành phẩm. Khi Loại Type khác 'B' thì lưu giá trị = rỗng");

                entity.Property(e => e.LocationId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("LocationID")
                    .HasComment("Mã quy trình công nghệ. Tham chiếu bảng Common.Locations.");

                entity.Property(e => e.MaterialItemId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MaterialItemID")
                    .HasComment("NVL - Phôi. Tham chiếu từ bảng [Inventory].[Items] với tính chất là V-Vật tư hàng hóa. Khi Loại Type khác 'V' thì lưu giá trị = rỗng");

                entity.Property(e => e.RowGuid)
                    .HasDefaultValueSql("(newid())")
                    .HasComment("Mã guid tự sinh của bảng");

                entity.Property(e => e.Amount)
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("Thành tiền = Trọng lượng phôi * Đơn giá.");

                entity.Property(e => e.ApecificGravity)
                    .HasColumnType("numeric(18, 2)")
                    .HasComment("Trọng lượng riêng");

                entity.Property(e => e.BomcategoriesPlanMixsGuid).HasColumnName("BOMCategoriesPlanMixsGuid");

                entity.Property(e => e.ConvertRate)
                    .HasColumnType("numeric(18, 3)")
                    .HasComment("Tỷ lệ chuyển đổi sang đvt của kho");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GroupItem)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Nhóm vật tư");

                entity.Property(e => e.High)
                    .HasColumnType("numeric(18, 2)")
                    .HasComment("Vật tư dạng tấm, khối (Chiều cao)");

                entity.Property(e => e.IsEdit).HasComment("Trạng thái giá đã cập nhật tỏng kho chứ: 0 - Chưa. 1- Rồi");

                entity.Property(e => e.Length)
                    .HasColumnType("numeric(18, 2)")
                    .HasComment("Dài");

                entity.Property(e => e.MachineId)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Note)
                    .HasMaxLength(250)
                    .HasComment("ghi chú");

                entity.Property(e => e.PercentNg)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PercentNG")
                    .HasComment("Tỷ lệ hỏng");

                entity.Property(e => e.PercentUsed)
                    .HasColumnType("numeric(18, 3)")
                    .HasComment("% Sử dụng, % tỷ lệ trộn");

                entity.Property(e => e.Shape)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('TAM')")
                    .HasComment("Hình dạng phôi. = TAM - Tấm, = TRON - Tròn");

                entity.Property(e => e.SizeId)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("SizeID")
                    .HasComment("VT dạng tròn, đường ký bên ngoài");

                entity.Property(e => e.SizeOd)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("SizeOD")
                    .HasComment("VT dạng tròn, đường kính bên trong");

                entity.Property(e => e.Type)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Loại: M - Dịnh mức vật tư. O - Nguyên phụ liệu và phụ kiện bên BTP");

                entity.Property(e => e.UnitId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UnitID")
                    .HasComment("Đơn vị tính đề nghị");

                entity.Property(e => e.UnitName)
                    .HasMaxLength(50)
                    .HasComment("Tên đvt đề nghị");

                entity.Property(e => e.UnitPrice)
                    .HasColumnType("numeric(18, 2)")
                    .HasComment("Đơn giá (Tự nhập hoặc lấy từ kho NVL)");

                entity.Property(e => e.Weight)
                    .HasColumnType("numeric(18, 4)")
                    .HasComment("Trọng lượng phôi \n(KG)");

                entity.Property(e => e.Wide)
                    .HasColumnType("numeric(18, 2)")
                    .HasComment("Vật tư dạng tấm, khối (Chiều rộng)");

                entity.HasOne(d => d.BomcategoriesPlanMixsGu)
                    .WithMany(p => p.Bomworkpieces)
                    .HasForeignKey(d => d.BomcategoriesPlanMixsGuid)
                    .HasConstraintName("FK_BOMWorkpieces_BOMCategoriesPlanMixs");

                entity.HasOne(d => d.Bomcategory)
                    .WithMany(p => p.Bomworkpieces)
                    .HasForeignKey(d => new { d.OrganizationGuid, d.Bomnumber })
                    .HasConstraintName("FK_BOMWorkpieces_BOMCategories");
            });

            modelBuilder.Entity<CastingCondition>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationGuid, e.MachineId, e.ItemId });

                entity.ToTable("CastingConditions", "Pro");

                entity.HasComment("Điều kiện đúc");

                entity.Property(e => e.OrganizationGuid).HasComment("Mã đơn vị");

                entity.Property(e => e.MachineId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasComment("Mã máy, lấy từ bảng Common.Machines");

                entity.Property(e => e.ItemId)
                    .HasMaxLength(100)
                    .HasComment("Mã sản phẩm. Lấy từ bảng VECT_AM.Inventory.Items");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(250)
                    .HasComment("Người phê duyệt");

                entity.Property(e => e.ApprovedDate)
                    .HasColumnType("datetime")
                    .HasComment("Ngày phê duyệt");

                entity.Property(e => e.ApprovedStatus).HasComment("Trạng thái phê duyệt");

                entity.Property(e => e.ConditionValue).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasComment("Ngày ban hành");

                entity.Property(e => e.DryingTemperature)
                    .HasColumnType("decimal(18, 3)")
                    .HasComment("Nhiệt độ sấy");

                entity.Property(e => e.DryingTime)
                    .HasColumnType("decimal(18, 3)")
                    .HasComment("Thời gian sấy");

                entity.Property(e => e.Height)
                    .HasColumnType("decimal(18, 3)")
                    .HasComment("độ cao khuôn");

                entity.Property(e => e.IsChecked).HasComment("Khi phiếu được \"Duyệt\" ở bước cuối cùng trong quy trình thì phiếu sẽ bị khóa, không thể cập nhật hoặc xử lý");

                entity.Property(e => e.IsLocked).HasComment("Khi phiếu được \"Duyệt\" ở bước cuối cùng trong quy trình thì phiếu sẽ bị khóa, không thể cập nhật hoặc xử lý");

                entity.Property(e => e.ItemGuid).HasComment("Mã guid của sản phẩm");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(250)
                    .HasComment("Tên sản phẩm");

                entity.Property(e => e.MachineName)
                    .HasMaxLength(255)
                    .HasComment("Tên máy");

                entity.Property(e => e.MachineTime)
                    .HasColumnType("decimal(18, 3)")
                    .HasComment("∑ TG CN SẢN XUẤT:");

                entity.Property(e => e.MaterialItemId)
                    .HasMaxLength(100)
                    .HasColumnName("MaterialItemID")
                    .HasComment("Mã nguyên vật liệu. Lấy từ bảng VECT_AM.Inventory.Items");

                entity.Property(e => e.MixedRatePhe)
                    .HasColumnType("decimal(18, 3)")
                    .HasComment("Tỷ lệ pha trộn phế");

                entity.Property(e => e.MixedRateZin)
                    .HasColumnType("decimal(18, 3)")
                    .HasComment("Tỷ lệ pha trộn Zin");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NumberEmployee).HasComment("Số nhân công sản xuất");

                entity.Property(e => e.ProdcutionTime)
                    .HasColumnType("decimal(18, 3)")
                    .HasComment("∑ TG CN SẢN XUẤT:");

                entity.Property(e => e.Qcby)
                    .HasMaxLength(250)
                    .HasColumnName("QCBy")
                    .HasComment("Xác nhận QC");

                entity.Property(e => e.Qcdate)
                    .HasColumnType("datetime")
                    .HasColumnName("QCDate")
                    .HasComment("Ngày QC xác nhận");

                entity.Property(e => e.Qcstatus)
                    .HasColumnName("QCStatus")
                    .HasComment("Trạng thái duyệt: 0 - Chờ duyệt. 1 - Đã duyệt  2 - Không duyệt");

                entity.Property(e => e.Quantity)
                    .HasColumnType("decimal(18, 3)")
                    .HasComment("Số lượng SP/Khuôn");

                entity.Property(e => e.RowGuid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Trạng thái của đơn: = W-Chờ duyệt; =Y-Đã duyệt; =N -Không duyệt; =F-Đã chuyển tiếp; =R-Đã trả lại;=C-Bị hủy (chỉ áp dụng cho người tạo); =D-Lưu nháp (chỉ áp dụng cho người tạo); =O-Khác (Áp dụng cho trường hợp không xác định)");

                entity.Property(e => e.Thick)
                    .HasColumnType("decimal(18, 3)")
                    .HasComment("độ dày khuôn");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(18, 3)")
                    .HasComment("Tổng");

                entity.Property(e => e.TotalQuantity)
                    .HasColumnType("decimal(18, 3)")
                    .HasComment("Tổng khối lượng sp");

                entity.Property(e => e.Version).HasComment("Phiên bản sử dụng");

                entity.Property(e => e.WaterTemperatureDynamic)
                    .HasColumnType("decimal(18, 3)")
                    .HasComment("Nhiệt độ nước động");

                entity.Property(e => e.WaterTemperatureStill)
                    .HasColumnType("decimal(18, 3)")
                    .HasComment("Nhiệt độ nước tĩnh");

                entity.Property(e => e.Wide)
                    .HasColumnType("decimal(18, 3)")
                    .HasComment("độ rộng khuôn");

                entity.Property(e => e.WorkFlowCurrent).HasComment("Mã bước hiện tại mà phiếu đang quản lý. Trường này nhằm xác định phiếu đang ở bước nào trong quy trình và trên cơ sở đó sẽ xác định được các bước đi tiếp theo dựa vào điều kiện trong sơ đồ của quy trình");

                entity.Property(e => e.WorkFlowGuid).HasComment("Mã WorkFlow dạng Guid, chỉ ra phiếu này đang áp dụng quy trình nào trong hệ thống các quy trình");

                entity.Property(e => e.WorkFlowsContent).HasComment("Quy trình đang áp dụng cho phiếu đăng ký . Trường này lưu lại sơ đồ quy trình xử lý của phiếu nhằm tăng cường hiệu năng xử lý, đồng thời khi có sự thay đổi về quy trình sẽ không ảnh hưởng những phiếu đang áp dụng hiện tại");
            });

            modelBuilder.Entity<CastingConditionProcess>(entity =>
            {
                entity.HasKey(e => e.RowGuid);

                entity.ToTable("CastingConditionProcess", "Pro");

                entity.Property(e => e.RowGuid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ActionName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasComment("Tên hành động xử lý (Lấy thông tin theo định nghĩa của quy trình xử lý) hoặc theo Form thiết kế (nếu không sử dụng quy trình)");

                entity.Property(e => e.Comment)
                    .HasMaxLength(255)
                    .HasComment("Nội dung ý kiến xử lý.");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DepartmentGuid).HasComment("Mã phòng ban, bộ phận dạng Guid");

                entity.Property(e => e.DepartmentId)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DepartmentID")
                    .HasComment("Mã phòng ban, bộ phận dạng tự nhập");

                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasComment("Tên phòng ban");

                entity.Property(e => e.EmployeeGuid).HasComment("Mã nhân viên xử lý dạng Guid");

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID")
                    .HasComment("Mã nhân viên xử lý dạng tự nhập");

                entity.Property(e => e.EmployeeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("Tên nhân viên xử lý");

                entity.Property(e => e.JobTitleName)
                    .HasMaxLength(50)
                    .HasComment("Tên chức danh người xử lý");

                entity.Property(e => e.LoginName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasComment("Tên đăng nhập của người dùng tạo");

                entity.Property(e => e.OrganizationGuid).HasComment("Mã tổ chức đơn vị của nhân viên");

                entity.Property(e => e.RecordGuid).HasComment("Mã khóa chính của ApplyOvertimes");

                entity.Property(e => e.WfstatusId)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("WFStatusID")
                    .HasComment("Trạng thái Workflow của từng bước trong quy trình");

                entity.Property(e => e.WorkFlowCurrent).HasComment("Mã bước hiện tại mà phiếu đang quản lý. Trường này nhằm xác định phiếu đang ở bước nào trong quy trình và trên cơ sở đó sẽ xác định được các bước đi tiếp theo dựa vào điều kiện trong sơ đồ của quy trình");
            });

            modelBuilder.Entity<CastingConditionsHistory>(entity =>
            {
                entity.HasKey(e => e.RowGuid);

                entity.ToTable("CastingConditionsHistories", "Pro");

                entity.Property(e => e.RowGuid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Body)
                    .HasMaxLength(250)
                    .HasComment("Ý kiến xử lý");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasComment("Ngày cập nhật");

                entity.Property(e => e.ItemId).HasMaxLength(100);

                entity.Property(e => e.MachineId)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RecordGuid).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.CastingCondition)
                    .WithMany(p => p.CastingConditionsHistories)
                    .HasForeignKey(d => new { d.OrganizationGuid, d.MachineId, d.ItemId })
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_CastingConditionsHistories_CastingConditions");
            });

            modelBuilder.Entity<CheckMachineDaily>(entity =>
            {
                entity.HasKey(e => e.RowGuid);

                entity.ToTable("CheckMachineDaily", "Maintenance");

                entity.HasComment("Bảng Kiểm tra máy móc hàng ngày");

                entity.Property(e => e.RowGuid).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("Số phiếu");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeliveryDate)
                    .HasColumnType("date")
                    .HasComment("Ngày giao(cho chọn bình thường)");

                entity.Property(e => e.MaintenanceFormId)
                    .HasMaxLength(255)
                    .HasColumnName("MaintenanceFormID");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Note).HasMaxLength(1000);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .HasComment("Mã sản phẩm. (Mã sản phẩm bảo dưỡng nếu có)");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(255)
                    .HasComment("Tên sản phẩm");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("= 0 Ngừng; = 1 Còn hạn .=2 Quá hạn. mặc định còn");

                entity.Property(e => e.Title)
                    .HasMaxLength(1000)
                    .HasComment("Nội dung bảo dưỡng");
            });

            modelBuilder.Entity<CheckMachineDailyDetail>(entity =>
            {
                entity.HasKey(e => e.RowGuid);

                entity.ToTable("CheckMachineDailyDetails", "Maintenance");

                entity.HasComment("Bảng chi tiết kiểm tra máy hàng ngày");

                entity.Property(e => e.RowGuid).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CriteriaTitle)
                    .HasMaxLength(250)
                    .HasComment("Tiêu chuẩn đánh giá");

                entity.Property(e => e.Method)
                    .HasMaxLength(250)
                    .HasComment("Phương thức kiểm tra");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.N1).HasMaxLength(250);

                entity.Property(e => e.N10).HasMaxLength(250);

                entity.Property(e => e.N11).HasMaxLength(250);

                entity.Property(e => e.N12).HasMaxLength(250);

                entity.Property(e => e.N13).HasMaxLength(250);

                entity.Property(e => e.N14).HasMaxLength(250);

                entity.Property(e => e.N15).HasMaxLength(250);

                entity.Property(e => e.N16).HasMaxLength(250);

                entity.Property(e => e.N17).HasMaxLength(250);

                entity.Property(e => e.N18).HasMaxLength(250);

                entity.Property(e => e.N19).HasMaxLength(250);

                entity.Property(e => e.N2).HasMaxLength(250);

                entity.Property(e => e.N20).HasMaxLength(250);

                entity.Property(e => e.N21).HasMaxLength(250);

                entity.Property(e => e.N22).HasMaxLength(250);

                entity.Property(e => e.N23).HasMaxLength(250);

                entity.Property(e => e.N24).HasMaxLength(250);

                entity.Property(e => e.N25).HasMaxLength(250);

                entity.Property(e => e.N26).HasMaxLength(250);

                entity.Property(e => e.N27).HasMaxLength(250);

                entity.Property(e => e.N28).HasMaxLength(250);

                entity.Property(e => e.N29).HasMaxLength(250);

                entity.Property(e => e.N3).HasMaxLength(250);

                entity.Property(e => e.N30).HasMaxLength(250);

                entity.Property(e => e.N31).HasMaxLength(250);

                entity.Property(e => e.N4).HasMaxLength(250);

                entity.Property(e => e.N5).HasMaxLength(250);

                entity.Property(e => e.N6).HasMaxLength(250);

                entity.Property(e => e.N7).HasMaxLength(250);

                entity.Property(e => e.N8).HasMaxLength(250);

                entity.Property(e => e.N9).HasMaxLength(250);

                entity.Property(e => e.RecordGuid).HasComment("Guid của bảng CheckMachineDaily");

                entity.Property(e => e.TestItemGuid).HasComment("Hạng mục kiểm tra");
            });

            modelBuilder.Entity<ConsumableMaterial>(entity =>
            {
                entity.HasKey(e => e.ConsumableMaterialGuid);

                entity.ToTable("ConsumableMaterials", "Maintenance");

                entity.HasComment("Bảng danh mục mã vật tư tiêu hao");

                entity.Property(e => e.ConsumableMaterialGuid).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasComment("Trạng thái");

                entity.Property(e => e.MaterialCode)
                    .HasMaxLength(50)
                    .HasComment("Mã vật tư");

                entity.Property(e => e.MaterialName)
                    .HasMaxLength(250)
                    .HasComment("Tên vật tư");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Note).HasMaxLength(255);

                entity.Property(e => e.UnitMeasureId)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("UnitMeasureID")
                    .HasComment("mã đơn vị tính");

                entity.Property(e => e.UnitMeasureName)
                    .HasMaxLength(250)
                    .HasComment("Tên đơn vị tính");
            });

            modelBuilder.Entity<CostNorm>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationGuid, e.CostId, e.StartDate, e.Type });

                entity.ToTable("CostNorms", "Common");

                entity.HasComment("Danh mục định mức chi phí nhân công, máy, gia công ngoài, chung, CCDC");

                entity.Property(e => e.OrganizationGuid).HasComment("Mã guid của đơn vị");

                entity.Property(e => e.CostId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("CostID")
                    .HasComment("Mã chi phí. \r\nNếu Loại chi phí là Nhân công thì CostID = LocationID (mã quy trình công nghệ). \r\nNếu Loại chi phí là Chi phí Máy thì CostID = MachineID (mã Máy). \r\nNếu Loại chi phí là Công cụ dụng cụ thì CostID = KnifeID (Mã dao).\r\nNếu loại chi phí là CP gia công ngoài, CP chung, CP Tài chính, CP thất thoát, Chi phí bao bì thì người dùng tự nhập ");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasComment("Ngày áp dụng định mức. Chỉ sử dụng định mức có ngày áp dụng mới nhất (tính theo OrganizationGuid,CostID,Type)");

                entity.Property(e => e.Type)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Loại chi phí. \r\n= N là Chi phí nhân công, \r\n= M là Chi phí Máy, \r\n= G là Chi phí gia công ngoài, \r\n= C là Chi phí chung, \r\n= D là Chi phí CCDC\r\n= T là Chi phí Tài chính, Lãi vay\r\n= K là Chi phí khác\r\n= A là Chi phí Thất thoát\r\n= B là Chi phí Bao bì");

                entity.Property(e => e.CostNormGuid)
                    .HasDefaultValueSql("(newid())")
                    .HasComment("Mã Guid tự sinh của bảng");

                entity.Property(e => e.CostPrice)
                    .HasColumnType("numeric(20, 2)")
                    .HasComment("Giá định mức. (tính theo đvt là phút đối với loại chi phí lương, chi phí máy, chi phí CCDC )");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasComment("Người tạo");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsuranceCostPrice)
                    .HasColumnType("numeric(20, 2)")
                    .HasComment("Chi phí bảo hiểm công ty đóng (tính theo đvt là phút). Chỉ áp dụng đối với loại chi phí = Nhân công");

                entity.Property(e => e.IsActive).HasComment("= 1 Sử dụng, = 0 Ngừng sử dụng");

                entity.Property(e => e.IsBoldFont).HasComment("= 1 Kiểu chữ in đậm, = 0 Chữ không in đậm");

                entity.Property(e => e.IsDefaultValue)
                    .HasDefaultValueSql("((0))")
                    .HasComment(" = 1 Là giá trị mặc định (sử dụng trên giao diện của các chức năng tham chiếu đến bảng này). = 0 Không là giá trị mặc định --> Áp dụng theo mã đơn vị + Loại chi phí Type");

                entity.Property(e => e.IsItalicFont).HasComment("= 1 Kiểu chữ in nghiêng, = 0 Chữ không in nghiêng");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasComment("Người sửa");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Nature)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('C')")
                    .HasComment("Tính chất. = T Mã tổng, = C Mã chi tiết");

                entity.Property(e => e.ParentCostId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ParentCostID")
                    .HasComment("Mã chi phí cha. Nếu Tính chất = Mã tổng thì ParentCostID = rỗng. Tham chiếu chính bảng hiện tại.");

                entity.Property(e => e.Rate)
                    .HasColumnType("numeric(18, 3)")
                    .HasComment("Tỷ lệ (nếu tính theo tỷ lệ %)");

                entity.Property(e => e.SupplierId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("SupplierID")
                    .HasComment("Mã NCC có sản xuất gia công. Tham chiếu bảng Objects bên ES_AM. Chỉ áp dụng với Loại chi phí là Gia công ngoài");

                entity.Property(e => e.SupplierName)
                    .HasMaxLength(255)
                    .HasComment("Tên NCC cung cấp dịch vụ gia công ngoài. (nếu chưa có trong danh mục NCC thì ng dùng tự nhập tên NCC)");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasComment("Tên của chi phí. Người dùng tự nhập khi Loại chi phí là CP gia công ngoài hoặc CP chung");

                entity.Property(e => e.UnitId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UnitID")
                    .HasComment("Mã đvt. Tham chiếu bảng [ES_AM].[Common].[Units]");

                entity.Property(e => e.UnitName)
                    .HasMaxLength(50)
                    .HasComment("Tên đơn vị tính");
            });

            modelBuilder.Entity<CostNormsByLocation>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationGuid, e.LocationId, e.StartDate, e.CostType });

                entity.ToTable("CostNormsByLocations", "Common");

                entity.HasComment("Định mức chi phí theo công đoạn");

                entity.Property(e => e.OrganizationGuid).HasComment("Mã guid của đơn vị");

                entity.Property(e => e.LocationId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("LocationID")
                    .HasComment("Mã công đoạn. Tham chiếu bảng Common.Locations");

                entity.Property(e => e.StartDate).HasComment("Ngày áp dụng. Định dạng YYYYMMDD");

                entity.Property(e => e.CostType)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasComment("Loại chi phí. = M - Máy; =G - Đồ gá; =D1 - Dụng cụ cắt; =D2 - Dụng cụ đo; = N - Nhà xưởng; = E - Điện; = C - Nhân công; = V1 - Vật liệu phụ");

                entity.Property(e => e.CostId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CostID")
                    .HasComment("Mã chi phí. Nếu loại chi phí\r\n= M - Máy thì CostID = Mã máy\r\n=G - Đồ gá thì CostID = Mã đồ gá\r\n=D1 - Dụng cụ cắt thì CostID = Mã dụng cụ cắt\r\n=D2 - Dụng cụ đo thì CostID = Mã dụng cụ đo\r\n= N - Nhà xưởng thì CostID = rỗng\r\n= E - Điện thì CostID = rỗng\r\n= C - Nhân công; \r\n= V1 - Vật liệu phụ");

                entity.Property(e => e.CostName).HasMaxLength(250);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LocationName)
                    .HasMaxLength(150)
                    .HasComment("Tên công đoạn");

                entity.Property(e => e.UnitPrice)
                    .HasColumnType("numeric(18, 2)")
                    .HasComment("Chi phí/phút");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.CostNormsByLocations)
                    .HasForeignKey(d => new { d.OrganizationGuid, d.LocationId })
                    .HasConstraintName("FK_CostNormsByLocations_Locations");
            });

            modelBuilder.Entity<CountryRegion>(entity =>
            {
                entity.HasKey(e => e.CountryRegionCode)
                    .HasName("PK_CountryRegion_CountryRegionCode");

                entity.ToTable("CountryRegion", "Person");

                entity.HasComment("Bảng danh mục chứa các mã chuẩn ISO của các quốc gia, khu vực");

                entity.HasIndex(e => e.Name, "AK_CountryRegion_Name")
                    .IsUnique();

                entity.Property(e => e.CountryRegionCode)
                    .HasMaxLength(3)
                    .HasComment("ISO standard code for countries and regions.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Ngày và thời gian bản ghi cập nhật lần cuối.");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("Tên quốc gia, khu vực.");
            });

            modelBuilder.Entity<DatabaseLog>(entity =>
            {
                entity.HasKey(e => e.DatabaseLogId)
                    .HasName("PK_DatabaseLog_DatabaseLogID")
                    .IsClustered(false);

                entity.ToTable("DatabaseLog");

                entity.HasComment("Audit table tracking all DDL changes made to the AdventureWorks database. Data is captured by the database trigger ddlDatabaseTriggerLog.");

                entity.Property(e => e.DatabaseLogId)
                    .HasColumnName("DatabaseLogID")
                    .HasComment("Primary key for DatabaseLog records.");

                entity.Property(e => e.DatabaseUser)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasComment("The user who implemented the DDL change.");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasComment("The type of DDL statement that was executed.");

                entity.Property(e => e.Object)
                    .HasMaxLength(128)
                    .HasComment("The object that was changed by the DDL statment.");

                entity.Property(e => e.PostTime)
                    .HasColumnType("datetime")
                    .HasComment("The date and time the DDL change occurred.");

                entity.Property(e => e.Schema)
                    .HasMaxLength(128)
                    .HasComment("The schema to which the changed object belongs.");

                entity.Property(e => e.Tsql)
                    .IsRequired()
                    .HasColumnName("TSQL")
                    .HasComment("The exact Transact-SQL statement that was executed.");

                entity.Property(e => e.XmlEvent)
                    .IsRequired()
                    .HasColumnType("xml")
                    .HasComment("The raw XML data generated by database trigger.");
            });

            modelBuilder.Entity<Device>(entity =>
            {
                entity.HasKey(e => e.RowGuid);

                entity.ToTable("Device", "Maintenance");

                entity.HasComment("Danh mục thiết bị");

                entity.Property(e => e.RowGuid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AssetId)
                    .HasMaxLength(50)
                    .HasColumnName("AssetID")
                    .HasComment("Mã Tài sản (Kế toán)");

                entity.Property(e => e.AssetName)
                    .HasMaxLength(250)
                    .HasComment("Tên thiết bị");

                entity.Property(e => e.Company)
                    .HasMaxLength(50)
                    .HasComment("Hãng SX");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(50)
                    .HasColumnName("DepartmentID");

                entity.Property(e => e.DepartmentName).HasMaxLength(255);

                entity.Property(e => e.DepreciationMonth).HasComment("Thời gian khấu hao (tháng)");

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(50)
                    .HasColumnName("DeviceID")
                    .HasComment("Mã TB (Sản xuất)*");

                entity.Property(e => e.ExpiryElectricDate)
                    .HasColumnType("date")
                    .HasComment("Hạn BH điện");

                entity.Property(e => e.ExpiryMechanicalDate)
                    .HasColumnType("date")
                    .HasComment("Hạn BH Cơ");

                entity.Property(e => e.FrequencyYear).HasComment("Tần suất bảo dưỡng năm ");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.ImagePath)
                    .HasMaxLength(250)
                    .HasComment("Tên ảnh");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Note).HasMaxLength(250);

                entity.Property(e => e.OrganizationName).HasMaxLength(255);

                entity.Property(e => e.Power)
                    .HasMaxLength(50)
                    .HasComment("Công suất*");

                entity.Property(e => e.ReceptionDay)
                    .HasColumnType("date")
                    .HasComment("Ngày/tháng  tiếp nhận*");

                entity.Property(e => e.Serial)
                    .HasMaxLength(50)
                    .HasComment("Seiri-Model");

                entity.Property(e => e.SupplierId)
                    .HasMaxLength(50)
                    .HasColumnName("SupplierID");

                entity.Property(e => e.SupplierName).HasMaxLength(255);

                entity.Property(e => e.Thumb)
                    .HasColumnType("image")
                    .HasComment("ảnh sản phẩm");

                entity.Property(e => e.Year).HasComment("Năm sản xuất");
            });

            modelBuilder.Entity<DeviceProblem>(entity =>
            {
                entity.HasKey(e => e.RowGuid);

                entity.ToTable("DeviceProblems", "Maintenance");

                entity.Property(e => e.RowGuid).ValueGeneratedNever();

                entity.Property(e => e.ActualTime).HasComment("Thời gian thực tế");

                entity.Property(e => e.Approve).HasComment("Duyệt phiếu bảo dưỡng ; 0 : chưa duyệt, 1 : Đã duyệt");

                entity.Property(e => e.ApproveStatus).HasComment("Duyệt phiếu cuả bộ phân sản xuất; 0 : chưa duyệt, 1 : Đã duyệt");

                entity.Property(e => e.Classification).HasComment("Phân loại lỗi (Cơ/Điện)*");

                entity.Property(e => e.Countermeasures)
                    .HasMaxLength(255)
                    .HasComment("Đối sách phòng ngừa phát sinh");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DateFinish)
                    .HasColumnType("datetime")
                    .HasComment("Thời gian hoàn thành*");

                entity.Property(e => e.DateProblem)
                    .HasColumnType("datetime")
                    .HasComment("Thời gian sự cố*");

                entity.Property(e => e.DateStop).HasComment("Thời gian dừng lại");

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(50)
                    .HasColumnName("DeviceID")
                    .HasComment("Mã TB (Sản xuất)*");

                entity.Property(e => e.DeviceName)
                    .HasMaxLength(250)
                    .HasComment("Tên thiết bị*");

                entity.Property(e => e.DeviceProblemId)
                    .HasMaxLength(50)
                    .HasColumnName("DeviceProblemID")
                    .HasComment("Mã phiếu SCTB");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(50)
                    .HasColumnName("EmployeeID")
                    .HasComment("Người sửa chữa*");

                entity.Property(e => e.MachineTypeId).HasMaxLength(255);

                entity.Property(e => e.ManagerApprove).HasComment("Trưởng phòng duyệt ; 0 : chưa duyệt, 1 : Đã duyệt");

                entity.Property(e => e.ManagerId)
                    .HasMaxLength(255)
                    .HasColumnName("ManagerID")
                    .HasComment("Trưởng phòng duyệt");

                entity.Property(e => e.MaterialCode)
                    .HasMaxLength(250)
                    .HasComment("Mã vật tư");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Note)
                    .HasMaxLength(250)
                    .HasComment("Ghi chú");

                entity.Property(e => e.OperatorId)
                    .HasMaxLength(50)
                    .HasColumnName("OperatorID")
                    .HasComment("Người đứng máy");

                entity.Property(e => e.OperatorName).HasMaxLength(250);

                entity.Property(e => e.OrganizationName).HasMaxLength(255);

                entity.Property(e => e.OutsourcingCosts)
                    .HasColumnType("money")
                    .HasComment("Chi phí thuê ngoài");

                entity.Property(e => e.PlanTime).HasComment("Thời gian dự kiến");

                entity.Property(e => e.Priority)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Mức ưu tiên : H: cao; L: thấp; U : Khẩn cấp");

                entity.Property(e => e.ProblemCurrent)
                    .HasMaxLength(250)
                    .HasComment("Hiện trạng lỗi*");

                entity.Property(e => e.ProblemStatus)
                    .HasMaxLength(250)
                    .HasComment("Tình trạng*");

                entity.Property(e => e.Quantity).HasComment("Số lượng");

                entity.Property(e => e.Reason)
                    .HasMaxLength(250)
                    .HasComment("Nguyên nhân*");

                entity.Property(e => e.Remedies)
                    .HasMaxLength(250)
                    .HasComment("Biện pháp khắc phục*");

                entity.Property(e => e.RepairCosts)
                    .HasColumnType("money")
                    .HasComment("Chi phí sửa chữa");

                entity.Property(e => e.RepairType)
                    .HasMaxLength(250)
                    .HasComment("Loại sửa chữa; 0: Sửa nội bộ , 1: Sửa ngoài");

                entity.Property(e => e.Results)
                    .HasMaxLength(50)
                    .HasComment("Kết quả (OK/NG)*");

                entity.Property(e => e.UnitId)
                    .HasMaxLength(50)
                    .HasColumnName("UnitID")
                    .HasComment("Đơn vị tính");
            });

            modelBuilder.Entity<DeviceProblemsComment>(entity =>
            {
                entity.HasKey(e => e.CommentGuid)
                    .HasName("PK_DeviceProblemsComments_1");

                entity.ToTable("DeviceProblemsComments", "Maintenance");

                entity.Property(e => e.CommentGuid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AvatarUrl).HasMaxLength(255);

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasComment("Nội dung comment");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DepartmentID");

                entity.Property(e => e.DepartmentName).HasMaxLength(50);

                entity.Property(e => e.EmployeeGuid).HasComment("Mã nhân viên thực hiện comment dạng Guid");

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID")
                    .HasComment("Mã nhân viên thực hiện comment dạng tự nhập");

                entity.Property(e => e.EmployeeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("Tên nhân viên");

                entity.Property(e => e.LoginName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasComment("Tên đăng nhập của người dùng tạo");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrganizationGuid).HasComment("Mã tổ chức dạng Guid, chỉ ra khách hàng thuộc tổ chức nào (nếu có)");

                entity.Property(e => e.ParentGuid).HasComment("Mã cha cho Comment. Mỗi comment chính sẽ có thể có các phản hồi tương ứng với comment đó");

                entity.Property(e => e.RecordGuid)
                    .HasDefaultValueSql("(newid())")
                    .HasComment("Mã bản ghi của các bảng tương ứng đẩy vào. Trường này đặt tên là RecordGuid nhằm đảm bảo việc viết lệnh hoặc store có cấu trúc chung.");
            });

            modelBuilder.Entity<DeviceProblemsCommentAttachment>(entity =>
            {
                entity.HasKey(e => e.AttachmentGuid);

                entity.ToTable("DeviceProblemsCommentAttachments", "Maintenance");

                entity.Property(e => e.AttachmentGuid)
                    .HasDefaultValueSql("(newid())")
                    .HasComment("Mã tệp đính kèm dạng Guid tự sinh");

                entity.Property(e => e.Attachment)
                    .IsRequired()
                    .HasComment("Nội dung file đính kèm");

                entity.Property(e => e.CloudPath)
                    .HasMaxLength(500)
                    .HasComment("Đường dẫn Cloud đồng bộ (nếu có). Trường này chỉ sử dụng trong trường hợp chạy dịch vụ đồng bộ với cloud");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DepartmentGuid).HasComment("Mã phòng ban dạng Guid nếu có. Chỉ áp dụng trong trường hợp quản lý file theo phòng ban");

                entity.Property(e => e.FileExtension)
                    .IsRequired()
                    .HasMaxLength(8)
                    .HasComment("Phần mở rộng của fle");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.FileSize).HasComment("Chứa dung lượng file tính theo Bytes");

                entity.Property(e => e.IsFolder).HasComment("Chỉ ra mục tin là thư mục hay không");

                entity.Property(e => e.IsHidden).HasComment("Thuộc tính chỉ ra file hoặc thư mục ở chế độ ẩn. =1 là ẩn, =0 là không ẩn. Mặc định =0");

                entity.Property(e => e.IsPublic)
                    .HasDefaultValueSql("((0))")
                    .HasComment("Thuộc tính chỉ ra file là Public (mức cùng tổ chức) hay Private. =0-Public;=1 Private mặc định =0. Nếu Private thì xét đến trường hợp mức Private nào thể hiện trong trường PrivateLevel");

                entity.Property(e => e.IsReadonly).HasComment("Thuộc tính chỉ ra file chỉ đọc. =1 Chỉ đọc.");

                entity.Property(e => e.IsSync).HasComment("Thuộc tính chỉ ra file đã đồng bộ lên Cloud hay chưa? Chỉ áp dụng cho file lưu trong bảng, không áp dụng cho file ngoài hệ thống (UrlExternal path). Trường này chỉ sử dụng trong trường hợp chạy dịch vụ đồng bộ với cloud");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModuleId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ModuleID")
                    .HasComment("Mã module mà file đính kèm đẩy vào (nếu có). Trường này nhằm quản lý các file một cách dễ dàng hơn theo từng module. Mã theo quy định.");

                entity.Property(e => e.OrganizationGuid).HasComment("Mã đơn vị, tổ chức");

                entity.Property(e => e.ParentGuid).HasComment("Lưu mã thư mục cha nếu thư mục có các thư mục con. Chỉ áp dụng cho bản ghi là thư mục.");

                entity.Property(e => e.PrivateLevel)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasComment("Cấp độ Private: =P-Dành cho cá nhân (Phụ thuộc người tạo); = D-Dành cho phòng ban (phụ thuộc mã phòng ban dạng Guid)");

                entity.Property(e => e.RecordGuid)
                    .HasDefaultValueSql("(newid())")
                    .HasComment("Mã bản ghi của các bảng tương ứng đẩy vào. Trường này đặt tên là RecordGuid nhằm đảm bảo việc viết lệnh hoặc store có cấu trúc chung.");

                entity.Property(e => e.SyncTime)
                    .HasColumnType("datetime")
                    .HasComment("Thời gian đồng bộ với Cloud nếu có. Trường này chỉ sử dụng trong trường hợp chạy dịch vụ đồng bộ với cloud");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasComment("Tiêu đề beeys cí");

                entity.Property(e => e.UrlExternal)
                    .HasMaxLength(250)
                    .HasComment("Đường dẫn của file nếu link đến thư viện lưu trữ ngoài (nếu có)");
            });

            modelBuilder.Entity<DeviceProblemsDetail>(entity =>
            {
                entity.HasKey(e => e.RowGuid);

                entity.ToTable("DeviceProblemsDetails", "Maintenance");

                entity.Property(e => e.RowGuid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeviceProblemId)
                    .HasColumnName("DeviceProblemID")
                    .HasComment("ID của phiếu bảo dưỡng");

                entity.Property(e => e.MaterialCode)
                    .HasMaxLength(50)
                    .HasComment("mã vật tư");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OutsourcingCosts)
                    .HasColumnType("money")
                    .HasComment("Chi phí thuê ngoài");

                entity.Property(e => e.Quantity).HasComment("Số lượng");

                entity.Property(e => e.RepairCosts)
                    .HasColumnType("money")
                    .HasComment("Chi phí sửa chữa");

                entity.Property(e => e.UnitMeasureId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("UnitMeasureID")
                    .HasComment("Đơn vị tính");

                entity.HasOne(d => d.DeviceProblem)
                    .WithMany(p => p.DeviceProblemsDetails)
                    .HasForeignKey(d => d.DeviceProblemId)
                    .HasConstraintName("FK_DeviceProblemsDetails_DeviceProblems");
            });

            modelBuilder.Entity<ErrorClassification>(entity =>
            {
                entity.HasKey(e => e.RowGuid);

                entity.ToTable("ErrorClassification", "Maintenance");

                entity.HasComment("Bảng phân loại lỗi của bảo dưỡng");

                entity.Property(e => e.RowGuid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasComment("Trạng thái");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Note)
                    .HasMaxLength(255)
                    .HasComment("Ghi chú");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasComment("Tiêu đề");
            });

            modelBuilder.Entity<ErrorLog>(entity =>
            {
                entity.ToTable("ErrorLog");

                entity.HasComment("Audit table tracking errors in the the AdventureWorks database that are caught by the CATCH block of a TRY...CATCH construct. Data is inserted by stored procedure dbo.uspLogError when it is executed from inside the CATCH block of a TRY...CATCH construct.");

                entity.Property(e => e.ErrorLogId)
                    .HasColumnName("ErrorLogID")
                    .HasComment("Primary key for ErrorLog records.");

                entity.Property(e => e.ErrorLine).HasComment("The line number at which the error occurred.");

                entity.Property(e => e.ErrorMessage)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .HasComment("The message text of the error that occurred.");

                entity.Property(e => e.ErrorNumber).HasComment("The error number of the error that occurred.");

                entity.Property(e => e.ErrorProcedure)
                    .HasMaxLength(126)
                    .HasComment("The name of the stored procedure or trigger where the error occurred.");

                entity.Property(e => e.ErrorSeverity).HasComment("The severity of the error that occurred.");

                entity.Property(e => e.ErrorState).HasComment("The state number of the error that occurred.");

                entity.Property(e => e.ErrorTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("The date and time at which the error occurred.");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasComment("The user who executed the batch in which the error occurred.");
            });

            modelBuilder.Entity<FieldType>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationGuid, e.FieldTypeId });

                entity.ToTable("FieldTypes", "Common");

                entity.HasComment("Danh mục các loại lĩnh vực sản xuất, kinh doanh");

                entity.Property(e => e.OrganizationGuid).HasComment("Mã guid của đơn vị");

                entity.Property(e => e.FieldTypeId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("FieldTypeID")
                    .HasComment("Mã Lĩnh vực sản xuất. ");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasComment("Người tạo");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .HasComment("Mô tả (nếu có)");

                entity.Property(e => e.IsActive).HasComment("Trạng thái Sử dụng. = 1 Đang sử dụng, = 0 Ngừng sử dụng");

                entity.Property(e => e.IsDefaultValue)
                    .HasDefaultValueSql("((0))")
                    .HasComment(" = 1 Là giá trị mặc định (sử dụng trên giao diện của các chức năng tham chiếu đến bảng này). = 0 Không là giá trị mặc định.");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasComment("Người sửa");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasComment("Tên khu vực");
            });

            modelBuilder.Entity<Infrastructure>(entity =>
            {
                entity.HasKey(e => e.RowGuid);

                entity.ToTable("Infrastructures", "Maintenance");

                entity.Property(e => e.RowGuid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ActualTime).HasComment("Thời gian thực tế");

                entity.Property(e => e.Approve).HasComment("Duyệt của bộ phận bảo dưỡng");

                entity.Property(e => e.ApproveStatus).HasComment("Duyệt phiếu cuả bộ phân sản xuất; 0 : chưa duyệt, 1 : Đã duyệt");

                entity.Property(e => e.Contents)
                    .HasMaxLength(250)
                    .HasComment("Tên thiết bị*");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DateFinish)
                    .HasColumnType("datetime")
                    .HasComment("Thời gian hoàn thành*");

                entity.Property(e => e.DateInfrastructures)
                    .HasColumnType("datetime")
                    .HasComment("Thời gian sự cố*");

                entity.Property(e => e.DateStop)
                    .HasColumnType("datetime")
                    .HasComment("Thời gian dừng*");

                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(50)
                    .HasColumnName("DepartmentID")
                    .HasComment("Mã TB (Sản xuất)*");

                entity.Property(e => e.DepartmentName).HasMaxLength(250);

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(50)
                    .HasColumnName("EmployeeID")
                    .HasComment("Người sửa chữa*");

                entity.Property(e => e.EmployeeRequestId)
                    .HasMaxLength(50)
                    .HasColumnName("EmployeeRequestID");

                entity.Property(e => e.InfrastructureId)
                    .HasMaxLength(50)
                    .HasColumnName("InfrastructureID")
                    .HasComment("Mã phiếu SCTB");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Note)
                    .HasMaxLength(250)
                    .HasComment("Ghi chú");

                entity.Property(e => e.OrganizationName).HasMaxLength(255);

                entity.Property(e => e.OutsourcingCosts)
                    .HasColumnType("money")
                    .HasComment("Chi phí thuê ngoài");

                entity.Property(e => e.PlanTime).HasComment("Thời gian dự kiến");

                entity.Property(e => e.RepairCosts)
                    .HasColumnType("money")
                    .HasComment("Chi phí sửa chữa");

                entity.Property(e => e.Results)
                    .HasMaxLength(50)
                    .HasComment("Kết quả (OK/NG)*");

                entity.Property(e => e.TimesFinish).HasComment("Thời gian hoàn thành*");
            });

            modelBuilder.Entity<InfrastructuresComment>(entity =>
            {
                entity.HasKey(e => e.CommentGuid)
                    .HasName("PK_InfrastructuresComments_1");

                entity.ToTable("InfrastructuresComments", "Maintenance");

                entity.Property(e => e.CommentGuid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AvatarUrl).HasMaxLength(255);

                entity.Property(e => e.Comment).HasComment("Nội dung comment");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DepartmentID");

                entity.Property(e => e.DepartmentName).HasMaxLength(50);

                entity.Property(e => e.EmployeeGuid).HasComment("Mã nhân viên thực hiện comment dạng Guid");

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID")
                    .HasComment("Mã nhân viên thực hiện comment dạng tự nhập");

                entity.Property(e => e.EmployeeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("Tên nhân viên");

                entity.Property(e => e.LoginName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasComment("Tên đăng nhập của người dùng tạo");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrganizationGuid).HasComment("Mã tổ chức dạng Guid, chỉ ra khách hàng thuộc tổ chức nào (nếu có)");

                entity.Property(e => e.ParentGuid).HasComment("Mã cha cho Comment. Mỗi comment chính sẽ có thể có các phản hồi tương ứng với comment đó");

                entity.Property(e => e.RecordGuid)
                    .HasDefaultValueSql("(newid())")
                    .HasComment("Mã bản ghi của các bảng tương ứng đẩy vào. Trường này đặt tên là RecordGuid nhằm đảm bảo việc viết lệnh hoặc store có cấu trúc chung.");
            });

            modelBuilder.Entity<JobCard>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationGuid, e.JobCardId });

                entity.ToTable("JobCards", "Pro");

                entity.HasComment("Thẻ công việc ngày + Báo cáo công việc ngày");

                entity.Property(e => e.OrganizationGuid).HasComment("Mã guid của đơn vị");

                entity.Property(e => e.JobCardId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("JobCardID")
                    .HasComment("Mã công việc tự nhập");

                entity.Property(e => e.ActualTotalMinute).HasComment("Tổng số phút thực hiện thực tế. = EndTime - StartTime");

                entity.Property(e => e.CamSheetId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("CamSheetID")
                    .HasComment("Mã Camsheet. Tham chiếu bảng [Pro].[BOMCamSheets]. ");

                entity.Property(e => e.CostPrice)
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("Chi phí lương nhân viên (khi có báo cáo công việc)");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasComment("Người tạo");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Ngày tạo");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasComment("Ngày của phiếu công việc sản xuất");

                entity.Property(e => e.DeparmentGuid).HasComment("Mã phòng ban bộ phận của nhân viên thực hiện dạng Guid");

                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DepartmentID")
                    .HasComment("Mã phòng ban bộ phận của nhân viên thực hiện dạng tự nhập");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .HasComment("Mô tả khác nếu có");

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID")
                    .HasComment("Mã nhân viên được giao phiếu (nhân viên sản xuất chính)");

                entity.Property(e => e.EmployeeId3)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID3");

                entity.Property(e => e.EmployeeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EmployeeName3).HasMaxLength(50);

                entity.Property(e => e.EndTime)
                    .HasColumnType("datetime")
                    .HasComment("Thời gian kết thúc. Cập nhật khi Nhân viên báo cáo công việc (có thể tự nhập hoặc tự động lấy thời gian thực)");

                entity.Property(e => e.ExpectedDate)
                    .HasColumnType("datetime")
                    .HasComment("Thời gian dự kiến hoàn thành");

                entity.Property(e => e.InsuranceCostPrice)
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("Chi phí bảo hiểm công ty đóng (khi có báo cáo công việc)");

                entity.Property(e => e.IsPause).HasComment("Tạm dừng công việc: 1 - Tạm dừng: 0 - Vẫn chạy. Tự động Tạm dừng khi Kế hoạch tổng hoặc kế hoạch ngày bị hủy");

                entity.Property(e => e.IsQc)
                    .HasColumnName("IsQC")
                    .HasComment("Trạng thái = 1 Chuyển QC kiểm tra, = 0 Không chuyển QC");

                entity.Property(e => e.IsReport).HasComment("Trạng thái báo cáo công việc: 0 - Chưa báo cáo. 1 - Đã báo cáo");

                entity.Property(e => e.IsRun).HasComment("Trạng thái in, chạy công việc: 1- Chạy CV: 0 - Lưu tạm");

                entity.Property(e => e.ItemId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ItemID")
                    .HasComment("Mã Thành phẩm sản xuất (Mã nội bộ). Tham chiếu bảng ES_AM.Inventory.Items");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(255)
                    .HasComment("Tên thành phẩm (tên sản phẩm nội bộ)");

                entity.Property(e => e.LocationId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("LocationID")
                    .HasComment("Mã quy trình công nghệ. Tham chiếu bảng Common.Locations.");

                entity.Property(e => e.LotNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Số lô sx. Tham chiếu bảng [Pro].[LotNumbers]");

                entity.Property(e => e.MachineCode)
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("Chi phí máy (khi có báo cáo công việc)");

                entity.Property(e => e.MachineId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MachineID")
                    .HasComment("Mã máy - nguồn lực sx. Tham chiếu bảng [Common].[Machines]");

                entity.Property(e => e.MachineRunTime)
                    .HasColumnType("numeric(18, 2)")
                    .HasComment("số giờ máy chạy ca1");

                entity.Property(e => e.MachineRunTime3)
                    .HasColumnType("numeric(18, 2)")
                    .HasComment("Số giờ máy chạy ca 3");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasComment("Người sửa cuối cùng");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrderDetailGuid).HasComment("mã guid chi tiết đơn đặt hàng. Tự động lưu theo kế hoạch sx ngày đã chọn.");

                entity.Property(e => e.OrderItemId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("OrderItemID")
                    .HasComment("Mã sản phẩm khách hàng đặt hàng. Tự động điền từ kế hoạch tổng [Pro].[ProductionPlans]");

                entity.Property(e => e.OrderNumber)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasComment("Số đơn đặt hàng. Tham chiếu bảng [ES_AM].[Sale].[Orders]. Tự động điền từ kế  hoạch tổng [Pro].[ProductionPlans]");

                entity.Property(e => e.PartItemId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PartItemID")
                    .HasComment("Mã bán thành phẩm. Tham chiếu từ bảng [Inventory].[Items] với tính chất là B-Bán thành phẩm. ");

                entity.Property(e => e.PartItemName)
                    .HasMaxLength(250)
                    .HasComment("Tên bán thành phẩm");

                entity.Property(e => e.PauseDate)
                    .HasColumnType("datetime")
                    .HasComment("Ngày tạm dừng");

                entity.Property(e => e.PauseName)
                    .HasMaxLength(250)
                    .HasComment("Người yêu cầu tạm dừng");

                entity.Property(e => e.PauseNote)
                    .HasMaxLength(250)
                    .HasComment("Nội dung tạm dừng");

                entity.Property(e => e.PlanDayGuid).HasComment("Mã guid kế hoạch sản xuất ngày. Tham chiếu bảng [Pro].[ProductionPlanDays]");

                entity.Property(e => e.ProductionOrderNo)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasComment("Số lệnh sản xuất (nếu lập kế hoạch từ Chi tiết lệnh sản xuất). Tự động điền từ kế hoạch tổng [Pro].[ProductionPlans]");

                entity.Property(e => e.Qrcode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("QRCode")
                    .HasComment("Mã QR code của thẻ công việc.");

                entity.Property(e => e.QuantityDelivered)
                    .HasColumnType("numeric(20, 2)")
                    .HasComment("Số lượng đã giao. (SL nhân viên sx chuyển cho QC kiểm tra). Cập nhật khi Nhân viên báo cáo công việc");

                entity.Property(e => e.QuantityDelivered3)
                    .HasColumnType("numeric(20, 2)")
                    .HasComment("Số lượng báo cáo ca 3");

                entity.Property(e => e.QuantityNg)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("QuantityNG");

                entity.Property(e => e.QuantityNg3)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("QuantityNG3")
                    .HasComment("Số lượng NG ca 3");

                entity.Property(e => e.QuantityPlan)
                    .HasColumnType("numeric(20, 2)")
                    .HasComment("Số lượng theo kế hoạch ngày.");

                entity.Property(e => e.QuantityRemaining).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.QuantityRemaining3).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ReportEmployeeId)
                    .HasMaxLength(50)
                    .HasColumnName("ReportEmployeeID")
                    .HasComment("Mã người cập nhật báo cáo");

                entity.Property(e => e.ReportEmployeeId3)
                    .HasMaxLength(50)
                    .HasColumnName("ReportEmployeeID3")
                    .HasComment("Mã nhân viên báo cáo ca 3");

                entity.Property(e => e.ReportEmployeeName)
                    .HasMaxLength(150)
                    .HasComment("Tên người cập nhật báo cáo");

                entity.Property(e => e.ReportEmployeeName3)
                    .HasMaxLength(150)
                    .HasComment("Tên nhân viên báo cáo ca 3");

                entity.Property(e => e.ReportExpectedDate)
                    .HasColumnType("datetime")
                    .HasComment("Ngày báo cáo vấn đề dản xuất");

                entity.Property(e => e.ReportLocationCode)
                    .HasMaxLength(50)
                    .HasComment("Mã khu vực báo cáo vấn đề dản xuất");

                entity.Property(e => e.ReportReasonNg)
                    .HasMaxLength(500)
                    .HasColumnName("ReportReasonNG")
                    .HasComment("Lý do NG báo cáo vấn đề dản xuất");

                entity.Property(e => e.RowGuid)
                    .HasDefaultValueSql("(newid())")
                    .HasComment("Mã guid tự sinh của bảng.");

                entity.Property(e => e.RunNumber).HasComment("Số chạy của mã công việc theo ngày");

                entity.Property(e => e.ScrapReasonId)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ScrapReasonId3)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ShiftId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ShiftID")
                    .HasComment("Mã ca làm việc. Tự động lấy theo ca chấm công của Người làm công việc tại ngày làm. Có thể sửa lại chọn từ danh mục ca làm việc bên Nhân sự");

                entity.Property(e => e.ShiftLeadId)
                    .HasMaxLength(50)
                    .HasColumnName("ShiftLeadID")
                    .HasComment("ID trưởng ca 1");

                entity.Property(e => e.ShiftLeadId3)
                    .HasMaxLength(50)
                    .HasColumnName("ShiftLeadID3")
                    .HasComment("ID trưởng ca 3");

                entity.Property(e => e.ShiftLeadName)
                    .HasMaxLength(100)
                    .HasComment("họ và tên trưởng ca 1");

                entity.Property(e => e.ShiftLeadName3)
                    .HasMaxLength(100)
                    .HasComment("họ và tên trưởng ca 3");

                entity.Property(e => e.ShiftName)
                    .HasMaxLength(150)
                    .HasComment("Tên ca");

                entity.Property(e => e.StartTime)
                    .HasColumnType("datetime")
                    .HasComment("Thời gian bắt đầu thực tế. Tự sinh tại thời điểm in phiếu công việc Hoặc tự nhập khi Nhân viên báo cáo công việc");

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("Trạng thái xác nhận:  CHO - Chờ. XN - Xác nhận");

                entity.Property(e => e.SupportorGuid).HasComment("Mã nhân viên hỗ trợ dạng Guid nếu có");

                entity.Property(e => e.SupportorId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SupportorID")
                    .HasComment("Mã nhân viên hỗ trợ dạng tự nhập nếu có");

                entity.Property(e => e.SupportorName)
                    .HasMaxLength(50)
                    .HasComment("Tên nhân viên hỗ trợ nếu có");

                entity.Property(e => e.TotalMinute).HasComment("Tổng số phút thực hiện (kế hoach)");

                entity.Property(e => e.UnitId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UnitID")
                    .HasComment("Ghi chú công việc.");

                entity.Property(e => e.UnitName)
                    .HasMaxLength(25)
                    .HasComment("Tên của Đơn vị tính chính");

                entity.HasOne(d => d.PlanDayGu)
                    .WithMany(p => p.JobCards)
                    .HasForeignKey(d => d.PlanDayGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobCards_ProductionPlanDays");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.JobCards)
                    .HasForeignKey(d => new { d.OrganizationGuid, d.LocationId })
                    .HasConstraintName("FK_JobCards_Locations");

                entity.HasOne(d => d.LotNumberNavigation)
                    .WithMany(p => p.JobCards)
                    .HasForeignKey(d => new { d.OrganizationGuid, d.LotNumber })
                    .HasConstraintName("FK_JobCards_LotNumbers");

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.JobCards)
                    .HasForeignKey(d => new { d.OrganizationGuid, d.MachineId })
                    .HasConstraintName("FK_JobCards_Machines");

                entity.HasOne(d => d.ScrapReason)
                    .WithMany(p => p.JobCards)
                    .HasForeignKey(d => new { d.OrganizationGuid, d.ScrapReasonId })
                    .HasConstraintName("FK_JobCards_ScrapReasons");
            });

            modelBuilder.Entity<JobCardsPqc>(entity =>
            {
                entity.HasKey(e => e.RowGuid);

                entity.ToTable("JobCardsPQC", "Pro");

                entity.HasComment("Danh sách QC kiểm tra bán thành phẩm, thành phẩm");

                entity.Property(e => e.RowGuid).ValueGeneratedNever();

                entity.Property(e => e.CheckBy)
                    .HasMaxLength(50)
                    .HasComment("Người kiểm tra");

                entity.Property(e => e.CheckDate)
                    .HasColumnType("datetime")
                    .HasComment("Ngày kiểm tra");

                entity.Property(e => e.CheckQuantityCancel)
                    .HasColumnType("numeric(20, 2)")
                    .HasComment("Số lượng kiểm tra hủy");

                entity.Property(e => e.CheckQuantityNg)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("CheckQuantityNG")
                    .HasComment("Số lượng kiểm tra NG");

                entity.Property(e => e.CheckQuantityOk)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("CheckQuantityOK")
                    .HasComment("Số lượng kiểm tra OK");

                entity.Property(e => e.CreatedBy).HasMaxLength(250);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DepartmentGuid).HasComment("Mã guid bộ phận kiểm tra");

                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(50)
                    .HasColumnName("DepartmentID")
                    .HasComment("Mã bộ phận kiểm tra");

                entity.Property(e => e.JobCardId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("JobCardID")
                    .HasComment("Mã công việc. Tham chiếu bảng Pro.JobCards");

                entity.Property(e => e.ModifiedBy).HasMaxLength(250);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OrganizationGuid).HasComment("Mã guid của đơn vị");

                entity.Property(e => e.Qrcode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("QRCode")
                    .HasComment("Mã QR code của thẻ công việc.");

                entity.Property(e => e.QuantityDelivered)
                    .HasColumnType("numeric(20, 2)")
                    .HasComment("Số lượng đã sản xuất (Số lượng đã giao bàn giao QC). Lấy từ QuantityDelivered của bảng JobCards");

                entity.Property(e => e.QuantityQc)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("QuantityQC")
                    .HasComment("Số lượng kiểm tra");

                entity.Property(e => e.ReasonId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ReasonID")
                    .HasComment("Mã Nguyên nhân lỗi. Tham chiếu bảng [Common].[ScrapReasons] với Type = N");

                entity.Property(e => e.ScrapReasonId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ScrapReasonID")
                    .HasComment("mã lý do lỗi. Tham chiếu bảng [Common].[ScrapReasons] với Type = L");

                entity.Property(e => e.Solutions)
                    .HasMaxLength(1000)
                    .HasComment("Khắc phục, xử lý");

                entity.HasOne(d => d.JobCard)
                    .WithMany(p => p.JobCardsPqcs)
                    .HasForeignKey(d => new { d.OrganizationGuid, d.JobCardId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobCardsPQC_JobCards");

                entity.HasOne(d => d.ScrapReason)
                    .WithMany(p => p.JobCardsPqcs)
                    .HasForeignKey(d => new { d.OrganizationGuid, d.ScrapReasonId })
                    .HasConstraintName("FK_JobCardsPQC_ScrapReasons");
            });

            modelBuilder.Entity<JobCardsQc>(entity =>
            {
                entity.HasKey(e => e.RowGuid);

                entity.ToTable("JobCardsQC", "Pro");

                entity.HasComment("Bảng quản lý giao việc của QC từ yêu cầu nhập kho thành phẩm");

                entity.Property(e => e.RowGuid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CheckById).HasMaxLength(50);

                entity.Property(e => e.CheckByName).HasMaxLength(250);

                entity.Property(e => e.CheckDate).HasColumnType("date");

                entity.Property(e => e.CreatedBy).HasMaxLength(250);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(50)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.EmployeeName).HasMaxLength(250);

                entity.Property(e => e.ModifiedBy).HasMaxLength(250);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Number).HasMaxLength(100);

                entity.Property(e => e.OrderNumber).HasMaxLength(50);

                entity.Property(e => e.ProductCode).HasMaxLength(50);

                entity.Property(e => e.ProductName).HasMaxLength(250);

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.QuantityNg)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("QuantityNG");

                entity.Property(e => e.QuantityOk)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("QuantityOK");

                entity.Property(e => e.SupportorId)
                    .HasMaxLength(50)
                    .HasColumnName("SupportorID");

                entity.Property(e => e.SupportorName).HasMaxLength(250);

                entity.Property(e => e.TicketNumber).HasMaxLength(50);

                entity.Property(e => e.UnitId).HasMaxLength(50);

                entity.Property(e => e.UnitName).HasMaxLength(50);
            });

            modelBuilder.Entity<JobCardsQcerror>(entity =>
            {
                entity.HasKey(e => e.RowGuid);

                entity.ToTable("JobCardsQCErrors", "Pro");

                entity.Property(e => e.RowGuid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasComment("Người tạo");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.JobCardId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("JobCardID");

                entity.Property(e => e.JobCardsQcguid).HasColumnName("JobCardsQCGuid");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasComment("Người sửa");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Note).HasMaxLength(250);

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ScrapReasonId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ScrapReasonID");

                entity.Property(e => e.ShiftId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.JobCardsQcgu)
                    .WithMany(p => p.JobCardsQcerrors)
                    .HasForeignKey(d => d.JobCardsQcguid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_JobCardsQCErrors_JobCardsQC");

                entity.HasOne(d => d.JobCard)
                    .WithMany(p => p.JobCardsQcerrors)
                    .HasForeignKey(d => new { d.OrganizationGuid, d.JobCardId })
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_JobCardsQCErrors_JobCards");

                entity.HasOne(d => d.ScrapReason)
                    .WithMany(p => p.JobCardsQcerrors)
                    .HasForeignKey(d => new { d.OrganizationGuid, d.ScrapReasonId })
                    .HasConstraintName("FK_JobCardsQCErrors_ScrapReasons");
            });

            modelBuilder.Entity<KhuonVecto>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("'khuon vecto$'");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CustomerCode)
                    .HasMaxLength(50)
                    .HasComment("Mã khách hàng");

                entity.Property(e => e.CustomerName).HasMaxLength(255);

                entity.Property(e => e.ItemGuid).HasMaxLength(255);

                entity.Property(e => e.ItemId).HasMaxLength(255);

                entity.Property(e => e.ItemName)
                    .HasMaxLength(250)
                    .HasComment("Guid bán thành phẩm dùng cho loại khuôn");

                entity.Property(e => e.MachineId).HasMaxLength(255);

                entity.Property(e => e.MachineTypeId).HasMaxLength(255);

                entity.Property(e => e.OrganizationGuid).HasMaxLength(255);

                entity.Property(e => e.ProductSide).HasMaxLength(255);

                entity.Property(e => e.Size).HasMaxLength(255);

                entity.Property(e => e.StandardShotNumber).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStandard).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Title).HasMaxLength(255);
            });

            modelBuilder.Entity<Knife>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationGuid, e.KnifeId });

                entity.ToTable("Knifes", "Common");

                entity.HasComment("Danh mục Dao");

                entity.Property(e => e.OrganizationGuid).HasComment("Mã guid của đơn vị");

                entity.Property(e => e.KnifeId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("KnifeID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasComment("Người tạo");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))")
                    .HasComment("Ngừng sử dụng = 0, Sử dụng = 1");

                entity.Property(e => e.IsDefaultValue)
                    .HasDefaultValueSql("((0))")
                    .HasComment(" = 1 Là giá trị mặc định (sử dụng trên giao diện của các chức năng tham chiếu đến bảng này). = 0 Không là giá trị mặc định.");

                entity.Property(e => e.KnifeGuid)
                    .HasDefaultValueSql("(newid())")
                    .HasComment("Mã guid tự động sinh của bảng");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasComment("Người sửa");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationGuid, e.LocationId });

                entity.ToTable("Locations", "Common");

                entity.HasComment("Quy trình công nghệ, giai đoạn");

                entity.Property(e => e.OrganizationGuid).HasComment("Mã guid của đơn vị");

                entity.Property(e => e.LocationId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("LocationID")
                    .HasComment("Mã quy trình công nghệ, công đoạn");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasComment("Người tạo");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .HasComment("Mô tả, ghi chú khi cần");

                entity.Property(e => e.IsActive).HasComment("= 1 Sử dụng, = 0 Ngừng sử dụng");

                entity.Property(e => e.IsBillet).HasComment("= 1 Sử dụng Phôi, = 0 Không sử dụng Phôi");

                entity.Property(e => e.IsDefaultValue)
                    .HasDefaultValueSql("((0))")
                    .HasComment(" = 1 Là giá trị mặc định (sử dụng trên giao diện của các chức năng tham chiếu đến bảng này). = 0 Không là giá trị mặc định.");

                entity.Property(e => e.IsProgram).HasComment("= 1 Có lập trình. = 0 Không lập trình");

                entity.Property(e => e.LocationGroupId)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("LocationGroupID")
                    .HasComment("Mã khu vực. Tham chiếu bảng LocationGroups");

                entity.Property(e => e.LocationGuid)
                    .HasDefaultValueSql("(newid())")
                    .HasComment("Mã guid tự sinh của quy trình công nghệ");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasComment("Người sửa");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ParentId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ParentID")
                    .HasComment("Thuộc công đoạn nào. Tham chiếu chính bảng hiện tại.");

                entity.Property(e => e.PreLoactionId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("PreLoactionID")
                    .HasComment("Mã quy trình công nghệ, công đoạn trước bắt buộc (nếu có)");

                entity.Property(e => e.SortOrder).HasComment("Thứ tự sắp xếp (Sử dụng khi cần)");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasComment("Tên quy trình công nghệ, công đoạn");

                entity.HasOne(d => d.LocationGroup)
                    .WithMany(p => p.Locations)
                    .HasForeignKey(d => new { d.OrganizationGuid, d.LocationGroupId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Locations_LocationGroups");

                entity.HasOne(d => d.LocationNavigation)
                    .WithMany(p => p.InverseLocationNavigation)
                    .HasForeignKey(d => new { d.OrganizationGuid, d.ParentId })
                    .HasConstraintName("FK_Locations_Locations");
            });

            modelBuilder.Entity<LocationGroup>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationGuid, e.LocationGroupId });

                entity.ToTable("LocationGroups", "Common");

                entity.HasComment("Danh mục khu vực, vị trí");

                entity.Property(e => e.OrganizationGuid).HasComment("Mã guid của đơn vị");

                entity.Property(e => e.LocationGroupId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("LocationGroupID")
                    .HasComment("Mã khu vực, người dụng tự nhập");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .HasComment("Địa chỉ");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasComment("Người tạo");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .HasComment("Mô tả (nếu có)");

                entity.Property(e => e.FieldTypeId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("FieldTypeID")
                    .HasComment("Lĩnh vực sản xuất. Tham chiếu bảng Common.TypeFields");

                entity.Property(e => e.GroupParentId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("GroupParentID")
                    .HasComment("Thuộc nhóm khu vực, vị trí. Tham chiếu bảng Common.LocationGroups. Lưu (LocationGroupID)");

                entity.Property(e => e.IsActive).HasComment("Trạng thái Sử dụng. = 1 Đang sử dụng, = 0 Ngừng sử dụng");

                entity.Property(e => e.IsDefaultValue)
                    .HasDefaultValueSql("((0))")
                    .HasComment(" = 1 Là giá trị mặc định (sử dụng trên giao diện của các chức năng tham chiếu đến bảng này). = 0 Không là giá trị mặc định.");

                entity.Property(e => e.LocationGroupGuid)
                    .HasDefaultValueSql("(newid())")
                    .HasComment("Mã guid tự sinh của bảng");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasComment("Người sửa");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasComment("Tên khu vực");

                entity.HasOne(d => d.FieldType)
                    .WithMany(p => p.LocationGroups)
                    .HasForeignKey(d => new { d.OrganizationGuid, d.FieldTypeId })
                    .HasConstraintName("FK_LocationGroups_FieldTypes");

                entity.HasOne(d => d.LocationGroupNavigation)
                    .WithMany(p => p.InverseLocationGroupNavigation)
                    .HasForeignKey(d => new { d.OrganizationGuid, d.GroupParentId })
                    .HasConstraintName("FK_LocationGroups_LocationGroups");
            });

            modelBuilder.Entity<LotNumber>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationGuid, e.LotNumber1 });

                entity.ToTable("LotNumbers", "Pro");

                entity.HasComment("Danh sách lô sản xuất");

                entity.Property(e => e.OrganizationGuid).HasComment("Mã guid của đơn vị");

                entity.Property(e => e.LotNumber1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LotNumber")
                    .HasComment("Số lô sản xuất");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasComment("Người tạo");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ExpiryDate)
                    .HasColumnType("date")
                    .HasComment("Hạn sử dụng.");

                entity.Property(e => e.ItemId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ItemID")
                    .HasComment("Mã thành phẩm. Tham chiếu bảng danh mục thành phẩm (ES_AM.Inventory.Items)");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(255)
                    .HasComment("Tên thành phẩm");

                entity.Property(e => e.ManufacturingDate)
                    .HasColumnType("date")
                    .HasComment("Ngày sản xuất (là ngày hoàn thành của công đoạn cuối cùng trước khi nhập kho = ngày đề nghị nhập kho thành phẩm). Được cập nhật tự động");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasComment("Người sửa");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OrderQty)
                    .HasColumnType("numeric(20, 0)")
                    .HasComment("Số lượng sản phẩm cần sản xuất");

                entity.Property(e => e.RowGuid)
                    .HasDefaultValueSql("(newid())")
                    .HasComment("Mã guid tự sinh của bảng.");

                entity.Property(e => e.ScrappedQty)
                    .HasColumnType("numeric(20, 0)")
                    .HasComment("Số lượng sản xuất lỗi. Tự động cập nhật khi QC check để nghị nhập kho thành phẩm");

                entity.Property(e => e.StockedQty)
                    .HasColumnType("numeric(20, 0)")
                    .HasComment("Số lượng nhập kho. Tự động cập nhật khi Nhập kho thành phẩm");
            });

            modelBuilder.Entity<Machine>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationGuid, e.MachineId });

                entity.ToTable("Machines", "Common");

                entity.HasComment("Danh mục máy");

                entity.Property(e => e.OrganizationGuid).HasComment("Mã guid của đơn vị");

                entity.Property(e => e.MachineId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MachineID")
                    .HasComment("Mã máy");

                entity.Property(e => e.AssetCardId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AssetCardID")
                    .HasComment("Số thẻ tài sản (nếu máy là Tài sản). Tham chiếu đến bảng [ES_AM].[Asset].[AssetCards] được quản lý bên hệ thống KẾ TOÁN. (sử dụng để lấy các thông tin khác của tài sản.)");

                entity.Property(e => e.AssetId)
                    .HasMaxLength(50)
                    .HasColumnName("AssetID");

                entity.Property(e => e.AutoClamping).HasMaxLength(50);

                entity.Property(e => e.AutoClampingPlate)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Capacity)
                    .HasMaxLength(250)
                    .HasComment("Công suất máy");

                entity.Property(e => e.Cheapendpoint)
                    .HasMaxLength(250)
                    .HasColumnName("CHEAPEndpoint")
                    .HasComment("Đầu bép điểm cuối R");

                entity.Property(e => e.Chiller).HasMaxLength(50);

                entity.Property(e => e.ClampingForce)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Coupler)
                    .HasMaxLength(250)
                    .HasComment("máy xấy nhựa  Coupler");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasComment("Người tạo");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Ngày tạo");

                entity.Property(e => e.CustomerCode)
                    .HasMaxLength(50)
                    .HasComment("Mã khách hàng");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(250)
                    .HasComment("Tên khách hàng");

                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DepartmentID");

                entity.Property(e => e.DepartmentName).HasMaxLength(255);

                entity.Property(e => e.DepreciationMonth).HasComment("Thời gian khấu hao (tháng)");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .HasComment("Đặc tả");

                entity.Property(e => e.Diameterhole)
                    .HasMaxLength(250)
                    .HasComment("Đầu bép Đường kính lỗ");

                entity.Property(e => e.EjectorStroke)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ElectricHeater)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ElectricMotor)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EmployeeGuidShift1).HasComment("Mã guid nhân viên đứng máy ca 1");

                entity.Property(e => e.EmployeeGuidShift3).HasComment("Mã guid nhân viên đứng máy ca 3");

                entity.Property(e => e.EmployeeIdShift1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Mã nhân viên đứng máy ca 1");

                entity.Property(e => e.EmployeeIdShift3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Mã nhân viên đứng máy ca 3");

                entity.Property(e => e.EmployeeNameShift1)
                    .HasMaxLength(250)
                    .HasComment("Tên nhân viên đứng máy ca 1");

                entity.Property(e => e.EmployeeNameShift3)
                    .HasMaxLength(250)
                    .HasComment("Tên nhân viên đứng máy ca 3");

                entity.Property(e => e.ExpiryElectricDate)
                    .HasColumnType("date")
                    .HasComment("Hạn BH điện");

                entity.Property(e => e.ExpiryMechanicalDate)
                    .HasColumnType("date")
                    .HasComment("Hạn BH Cơ");

                entity.Property(e => e.FixPlate)
                    .HasMaxLength(250)
                    .HasComment("số lượng core \"bên cố định\nFix plate\"");

                entity.Property(e => e.FrequencyYear).HasComment("Tần suất bảo dưỡng năm ");

                entity.Property(e => e.HeatingType).HasMaxLength(50);

                entity.Property(e => e.HorizontalPlaten)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HorizontalTie)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Hydraulic).HasMaxLength(50);

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(250)
                    .HasComment("Đường dẫn đến hình ảnh của Máy");

                entity.Property(e => e.InjectionPressure)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InjectionRate)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InjectionSpeed)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsActive)
                    .HasDefaultValueSql("((0))")
                    .HasComment("Trạng thái máy; true : sử dụng ; false: không sử dụng");

                entity.Property(e => e.IsDefaultValue)
                    .HasDefaultValueSql("((0))")
                    .HasComment(" = 1 Là giá trị mặc định (sử dụng trên giao diện của các chức năng tham chiếu đến bảng này). = 0 Không là giá trị mặc định.");

                entity.Property(e => e.ItemGuid).HasComment("Tên bán thành phẩm dùng cho loại khuôn");

                entity.Property(e => e.ItemId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Mã bán thành phẩm dùng cho loại khuôn");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(250)
                    .HasComment("Guid bán thành phẩm dùng cho loại khuôn");

                entity.Property(e => e.LocatingRingDia)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LocationGroupId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("LocationGroupID")
                    .HasComment("Thuộc Mã khu vực, vị trí. tham chiếu bảng LocationGroups");

                entity.Property(e => e.LocationId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("LocationID")
                    .HasComment("Thuộc Mã công đoạn. Tham chiếu bảng Locations");

                entity.Property(e => e.MachineGuid)
                    .HasDefaultValueSql("(newid())")
                    .HasComment("Mã guid tự sinh của bảng");

                entity.Property(e => e.MachineTypeId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("MachineTypeID")
                    .HasComment("Mã loại máy. Tham chiếu bảng [Common].[MachineTypes]");

                entity.Property(e => e.MadeIn)
                    .HasMaxLength(150)
                    .HasComment("Xuất xứ");

                entity.Property(e => e.MainVoltage).HasMaxLength(50);

                entity.Property(e => e.Maker).HasMaxLength(50);

                entity.Property(e => e.Manual).HasMaxLength(50);

                entity.Property(e => e.ManualClampingPlate)
                    .HasMaxLength(250)
                    .HasComment("phương pháp nắp khuôn Bằng tay (Manual) chỉ cần kết xuất xuống excel. ko cần ttreen phần mềm");

                entity.Property(e => e.ManufacturingYear).HasComment("Năm sản xuất");

                entity.Property(e => e.Max)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaxClampingStrock)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaxMold)
                    .HasMaxLength(250)
                    .HasComment("chiều cao lớn nhất khuôn");

                entity.Property(e => e.MinClampingStrock)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MinMold)
                    .HasMaxLength(250)
                    .HasComment("chiều cao nhỏ nhất khuôn");

                entity.Property(e => e.ModelName)
                    .HasMaxLength(250)
                    .HasComment("Tên Model");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasComment("Người sửa cuối cùng");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.MoveablePlate)
                    .HasMaxLength(250)
                    .HasComment("số lượng core bên động");

                entity.Property(e => e.NoofZone)
                    .HasMaxLength(250)
                    .HasComment("Hot Runner khu vực nhiệt Zone");

                entity.Property(e => e.NormalWaterAbility)
                    .HasMaxLength(250)
                    .HasComment("Các thiết bị nước Nước thường");

                entity.Property(e => e.Note)
                    .HasMaxLength(250)
                    .HasComment("Ghi chú");

                entity.Property(e => e.Number)
                    .HasDefaultValueSql("((0))")
                    .HasComment("SỐ SẢN PHẨM TRÊN KHUÔN ");

                entity.Property(e => e.Numberbroken).HasComment("Số lần báo hỏng máy");

                entity.Property(e => e.Plasticizingcapacity)
                    .HasMaxLength(250)
                    .HasComment("Khả năng tiêu thụ NVL");

                entity.Property(e => e.ProductSide)
                    .HasMaxLength(50)
                    .HasComment("Mặt sp( nhám ,bóng )");

                entity.Property(e => e.ProductionTime)
                    .HasColumnType("numeric(18, 3)")
                    .HasComment("Thời gian sản xuất");

                entity.Property(e => e.Quantity)
                    .HasDefaultValueSql("((0))")
                    .HasComment("Số lượng");

                entity.Property(e => e.ReceptionDay)
                    .HasColumnType("date")
                    .HasComment("Ngày/tháng  tiếp nhận*");

                entity.Property(e => e.RobotModelName).HasMaxLength(250);

                entity.Property(e => e.Screw)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ScrewSpeed)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Serial)
                    .HasMaxLength(50)
                    .HasComment("Seiri-Model");

                entity.Property(e => e.ShiftId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ShiftID")
                    .HasComment("Ca máy làm việc nếu có");

                entity.Property(e => e.ShiftLeadName1).HasMaxLength(100);

                entity.Property(e => e.ShiftLeadName3).HasMaxLength(100);

                entity.Property(e => e.ShotWeight)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Size)
                    .HasMaxLength(250)
                    .HasComment("KÍCH THƯỚC KHUÔN ");

                entity.Property(e => e.StandardShotNumber)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("Tiêu chuẩn shot bảo dưỡng");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasComment("Ngày bắt đầu");

                entity.Property(e => e.Status)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasComment("Tình trạng máy: =OK-Hoạt động; = HO-Hỏng; =KH-Khác");

                entity.Property(e => e.Stroke).HasMaxLength(50);

                entity.Property(e => e.SupplierId)
                    .HasMaxLength(50)
                    .HasColumnName("SupplierID");

                entity.Property(e => e.SupplierName).HasMaxLength(255);

                entity.Property(e => e.TemperatureController).HasMaxLength(50);

                entity.Property(e => e.ThicknessMold).HasMaxLength(50);

                entity.Property(e => e.Thumb)
                    .HasColumnType("image")
                    .HasComment("ảnh sản phẩm");

                entity.Property(e => e.TieCrusher).HasMaxLength(250);

                entity.Property(e => e.TimeStandard).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasComment("Tên máy");

                entity.Property(e => e.ToolId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ToolID")
                    .HasComment("Số thẻ CCDC. (Nếu máy là CCDC). Tham chiếu đến bảng [ES_AM].[Tool].[ToolVouchers] được quản lý bên hệ thống KẾ TOÁN");

                entity.Property(e => e.ToolVoucherGuid).HasComment("Mã guid của thẻ CCDC. Tham chiếu đến bảng [ES_AM].[Tool].[ToolVouchers] được quản lý bên hệ thống KẾ TOÁN");

                entity.Property(e => e.UtilizedOilQuantity).HasMaxLength(50);

                entity.Property(e => e.VerticalPlaten)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VerticalTie)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Machines)
                    .HasForeignKey(d => new { d.OrganizationGuid, d.LocationId })
                    .HasConstraintName("FK_Machines_Locations");

                entity.HasOne(d => d.MachineType)
                    .WithMany(p => p.Machines)
                    .HasForeignKey(d => new { d.OrganizationGuid, d.MachineTypeId })
                    .HasConstraintName("FK_Machines_MachineTypes");
            });

            modelBuilder.Entity<MachineError>(entity =>
            {
                entity.HasKey(e => e.RowGuid);

                entity.ToTable("MachineErrors", "Common");

                entity.HasComment("Lịch sử báo máy hỏng");

                entity.Property(e => e.RowGuid).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasComment("Người tạo");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Ngày tạo");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasComment("Ngày báo hỏng");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasComment("Mô tả tình trạng máy, lý do hỏng");

                entity.Property(e => e.IsDefaultValue)
                    .HasDefaultValueSql("((0))")
                    .HasComment(" = 1 Là giá trị mặc định (sử dụng trên giao diện của các chức năng tham chiếu đến bảng này). = 0 Không là giá trị mặc định.");

                entity.Property(e => e.MachineId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MachineID")
                    .HasComment("Mã máy báo hỏng. Tham chiếu bảng Common.Machines");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasComment("Người sửa cuối cùng");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrganizationGuid).HasComment("Mã guid của đơn vị");

                entity.Property(e => e.Solution)
                    .HasMaxLength(500)
                    .HasComment("Hướng xử lý");

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.MachineErrors)
                    .HasForeignKey(d => new { d.OrganizationGuid, d.MachineId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MachineErrors_Machines");
            });

            modelBuilder.Entity<MachineType>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationGuid, e.MachineTypeId });

                entity.ToTable("MachineTypes", "Common");

                entity.HasComment("Danh mục loại máy");

                entity.Property(e => e.OrganizationGuid).HasComment("Mã guid của đơn vị");

                entity.Property(e => e.MachineTypeId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("MachineTypeID")
                    .HasComment("Mã loại máy tự nhập");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasComment("Người tạo");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .HasComment("Mô tả, ghi chú khi cần");

                entity.Property(e => e.IsActive).HasComment("= 1 Sử dụng, = 0 Ngừng sử dụng");

                entity.Property(e => e.IsDefaultValue)
                    .HasDefaultValueSql("((0))")
                    .HasComment(" = 1 Là giá trị mặc định (sử dụng trên giao diện của các chức năng tham chiếu đến bảng này). = 0 Không là giá trị mặc định.");

                entity.Property(e => e.MachineTypeGuid)
                    .HasDefaultValueSql("(newid())")
                    .HasComment("Mã guid tự sinh của quy trình công nghệ");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasComment("Người sửa");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Title).HasMaxLength(255);
            });

            modelBuilder.Entity<MachinesItem>(entity =>
            {
                entity.HasKey(e => e.RowGuid);

                entity.ToTable("MachinesItems", "Common");

                entity.Property(e => e.RowGuid).ValueGeneratedNever();

                entity.Property(e => e.ItemId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ItemName).HasMaxLength(250);

                entity.Property(e => e.MachineId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MachineID");

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.MachinesItems)
                    .HasForeignKey(d => new { d.OrganizationGuid, d.MachineId })
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_MachinesItems_Machines");
            });

            modelBuilder.Entity<MaintenanceContent>(entity =>
            {
                entity.HasKey(e => e.RowGuid);

                entity.ToTable("MaintenanceContent", "Maintenance");

                entity.Property(e => e.RowGuid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ContentMain).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CriteriaTitle)
                    .HasMaxLength(250)
                    .HasComment("Tiêu chuẩn đánh giá");

                entity.Property(e => e.Method)
                    .HasMaxLength(250)
                    .HasComment("Phương thức kiểm tra");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Note).HasMaxLength(255);

                entity.Property(e => e.Times)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MaintenanceForm>(entity =>
            {
                entity.HasKey(e => e.RowGuid);

                entity.ToTable("MaintenanceForm", "Maintenance");

                entity.HasComment("Danh sách các mẫu của bảo dưỡng");

                entity.Property(e => e.RowGuid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MaintenanceFormId)
                    .HasMaxLength(50)
                    .HasColumnName("MaintenanceFormID");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Note)
                    .HasMaxLength(500)
                    .HasComment("ghi chú");

                entity.Property(e => e.OrganizationName).HasMaxLength(255);

                entity.Property(e => e.Title)
                    .HasMaxLength(250)
                    .HasComment("Tiêu đề");
            });

            modelBuilder.Entity<MaintenanceFormDetail>(entity =>
            {
                entity.HasKey(e => e.RowGuid);

                entity.ToTable("MaintenanceFormDetails", "Maintenance");

                entity.Property(e => e.RowGuid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CriteriaTitle)
                    .HasMaxLength(250)
                    .HasComment("Tiêu chuẩn đánh giá");

                entity.Property(e => e.MaintenanceContentId).HasColumnName("MaintenanceContentID");

                entity.Property(e => e.MaintenanceFormId).HasColumnName("MaintenanceFormID");

                entity.Property(e => e.MaterialCode).HasMaxLength(50);

                entity.Property(e => e.Method)
                    .HasMaxLength(250)
                    .HasComment("Phương thức kiểm tra");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Note).HasMaxLength(250);

                entity.Property(e => e.Results).HasMaxLength(50);

                entity.Property(e => e.SortOrder).HasComment("Sắp xếp");

                entity.Property(e => e.Times).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UnitMeasureId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("UnitMeasureID");
            });

            modelBuilder.Entity<MaintenanceManagement>(entity =>
            {
                entity.HasKey(e => e.MaintainGuid);

                entity.ToTable("MaintenanceManagement", "Maintenance");

                entity.Property(e => e.MaintainGuid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .HasComment("Địa chỉ");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .HasComment("Mã Barcode (của sản phẩm bảo dưỡng)");

                entity.Property(e => e.ConfirmDate)
                    .HasColumnType("datetime")
                    .HasComment("Ngày xác nhận");

                entity.Property(e => e.ConfirmStatus).HasComment("Trạng thái xác nhận");

                entity.Property(e => e.Content)
                    .HasMaxLength(1000)
                    .HasComment("Nội dung bảo dưỡng");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(50)
                    .HasColumnName("CustomerID")
                    .HasComment("Mã khách hàng (Lấy theo Mã dự án hoặc Số đơn hàng)");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(255)
                    .HasComment("Tên khách hàng (Theo Mã khách hàng)");

                entity.Property(e => e.DeliveryDate)
                    .HasColumnType("date")
                    .HasComment("Ngày giao(cho chọn bình thường)");

                entity.Property(e => e.DeliveryNumber)
                    .HasMaxLength(50)
                    .HasComment("Số phiếu giao hàng, Dựa vào OrderNumber để kiểm tra trong bảng tickets để Lấy TicketNumber=DeliveryNumber (Chỉ áp dụng là phiếu xuất Type==1)");

                entity.Property(e => e.FrequencyYear).HasComment("Năm");

                entity.Property(e => e.IsLocked).HasComment("nếu =1 thì việc duy trì bị khóa lại. Mặc định =0 (cho vào form sửa khóa lại)");

                entity.Property(e => e.MachineTypeId).HasMaxLength(255);

                entity.Property(e => e.MaintainNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("Số phiếu bảo dưỡng");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NextDate)
                    .HasColumnType("date")
                    .HasComment("Ngày bảo dưỡng tiếp theo (cho chọn)");

                entity.Property(e => e.Note)
                    .HasMaxLength(255)
                    .HasComment("ghi chú");

                entity.Property(e => e.OrderNumber)
                    .HasMaxLength(50)
                    .HasComment("Số đơn hàng");

                entity.Property(e => e.OrganizationName).HasMaxLength(255);

                entity.Property(e => e.PlanType)
                    .HasMaxLength(255)
                    .HasComment("Loại kế hoạch 01 : bảo dưỡng ; 02 : Kiểm định định kỳ");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(50)
                    .HasComment("Mã sản phẩm. (Mã sản phẩm bảo dưỡng nếu có)");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(255)
                    .HasComment("Tên sản phẩm");

                entity.Property(e => e.ProjectId)
                    .HasMaxLength(50)
                    .HasColumnName("ProjectID")
                    .HasComment("Mã dự án: nhiều khi mã dự án khác với mã đơn hàng. do đó cần lưu thêm mã dự án");

                entity.Property(e => e.ProjectTitle)
                    .HasMaxLength(255)
                    .HasComment("Tiêu đề của dự án, lấy ứng với mã dự án");

                entity.Property(e => e.Serial)
                    .HasMaxLength(50)
                    .HasComment("Số Serial (của sản phẩm bảo dưỡng)");

                entity.Property(e => e.Status).HasComment("= 0 Ngừng; = 1 Còn hạn .=2 Quá hạn. mặc định còn");

                entity.Property(e => e.TotalTimes).HasComment("Số lần bảo dưỡng, bảo trì định kỳ cho sản phẩm, máy móc. Có thể tạo tự động hoặc thủ công (Dựa vào bảng OrderMaintainDetails đếm số bản ghi theo IDOrrderMaintain)");

                entity.Property(e => e.WarrantyTicketsDetailId).HasColumnName("WarrantyTicketsDetailID");
            });

            modelBuilder.Entity<MaintenanceManagementAttachment>(entity =>
            {
                entity.HasKey(e => e.Rowguid);

                entity.ToTable("MaintenanceManagementAttachments", "Maintenance");

                entity.Property(e => e.Rowguid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ExternalUrl).HasMaxLength(255);

                entity.Property(e => e.FileExtension).HasMaxLength(8);

                entity.Property(e => e.FileName).HasMaxLength(255);

                entity.Property(e => e.FileNameRoot).HasMaxLength(255);

                entity.Property(e => e.MaintainDetailId).HasColumnName("MaintainDetailID");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Summary).HasMaxLength(500);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<MaintenanceManagementComment>(entity =>
            {
                entity.HasKey(e => e.CommentGuid)
                    .HasName("PK_MaintenanceManagementComments_1");

                entity.ToTable("MaintenanceManagementComments", "Maintenance");

                entity.HasComment("Bảng comment của kế hoạch năm bảo dưỡng");

                entity.Property(e => e.CommentGuid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AvatarUrl).HasMaxLength(255);

                entity.Property(e => e.Comment).HasComment("Nội dung comment");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DepartmentID");

                entity.Property(e => e.DepartmentName).HasMaxLength(50);

                entity.Property(e => e.EmployeeGuid).HasComment("Mã nhân viên thực hiện comment dạng Guid");

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID")
                    .HasComment("Mã nhân viên thực hiện comment dạng tự nhập");

                entity.Property(e => e.EmployeeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("Tên nhân viên");

                entity.Property(e => e.LoginName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasComment("Tên đăng nhập của người dùng tạo");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrganizationGuid).HasComment("Mã tổ chức dạng Guid, chỉ ra khách hàng thuộc tổ chức nào (nếu có)");

                entity.Property(e => e.ParentGuid).HasComment("Mã cha cho Comment. Mỗi comment chính sẽ có thể có các phản hồi tương ứng với comment đó");

                entity.Property(e => e.RecordGuid)
                    .HasDefaultValueSql("(newid())")
                    .HasComment("Mã bản ghi của các bảng tương ứng đẩy vào. Trường này đặt tên là RecordGuid nhằm đảm bảo việc viết lệnh hoặc store có cấu trúc chung.");
            });

            modelBuilder.Entity<MaintenanceManagementDetail>(entity =>
            {
                entity.HasKey(e => e.MaintainDetailGuid);

                entity.ToTable("MaintenanceManagementDetails", "Maintenance");

                entity.Property(e => e.MaintainDetailGuid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ActualDateFrom)
                    .HasColumnType("date")
                    .HasComment("Ngày thực tế (Từ ngày)");

                entity.Property(e => e.ActualDateTo)
                    .HasColumnType("date")
                    .HasComment("Ngày thực tế (Đến ngày)");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .HasComment("Địa chỉ người bảo dưỡng");

                entity.Property(e => e.Body)
                    .HasMaxLength(500)
                    .HasComment("Chú thích (nếu có). Nếu thảo luận nhiều sẽ được quản lý ở bảng commnent");

                entity.Property(e => e.ConfirmDate).HasColumnType("date");

                entity.Property(e => e.ConfirmDateFrom)
                    .HasColumnType("date")
                    .HasComment("Ngày xác nhận (Từ ngày)");

                entity.Property(e => e.ConfirmDateTo)
                    .HasColumnType("date")
                    .HasComment("Ngày xác nhận (Đến ngày)");

                entity.Property(e => e.ContactName)
                    .HasMaxLength(50)
                    .HasComment("Người liên hệ bảo dưỡng, hoặc người phối hợp hỗ trợ bảo dưỡng");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(50)
                    .HasColumnName("EmployeeID")
                    .HasComment("Mã Tên nhân viên bảo trì, bảo dưỡng");

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(50)
                    .HasComment("Tên nhân viên bảo trì, bảo dưỡng, hoặc người chịu trách nhiệm chính trong việc này.");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasComment("Kết thúc bảo dưỡng");

                entity.Property(e => e.IsCompleted).HasComment("Trạng thái chỉ ra rằng việc bảo trì bảo dưỡng: đã hoàn thành hoặc chưa hoàn thành. =0 là chưa hoàn thành, =1 đã hoàn thành (mặc định =0)");

                entity.Property(e => e.IsConfirm).HasComment("=0: Chưa bảo trì bảo dưỡng, =1 đã bảo trì bảo dưỡng");

                entity.Property(e => e.MaintainTypeId)
                    .HasColumnName("MaintainTypeID")
                    .HasComment("Lấy từ bảng Common.MaintainTypes");

                entity.Property(e => e.MaintenanceRequestId).HasColumnName("MaintenanceRequestID");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Note)
                    .HasMaxLength(500)
                    .HasComment("Chú thích (nếu có). Nếu thảo luận nhiều sẽ được quản lý ở bảng commnent");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .HasComment("Số điện thoại người liên hệ bảo dưỡng");

                entity.Property(e => e.Result)
                    .HasMaxLength(255)
                    .HasComment("Kết quả");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasComment("Bắt đầu bảo dưỡng");

                entity.Property(e => e.Times).HasComment("Lưu bảo dưỡng lần thứ mấy trong chu kỳ bảo hành, bảo dưỡng sản phẩm. Có thể tạo thủ công (áp dụng cho trường hợp bảo trì không có khoảng thời gian bằng nhau) hoặc tự động dựa trên tổng số lần bảo trì (chỉ áp dụng cho trường hợp bảo trì định kỳ với khoảng thời gian bằng nhau)");

                entity.HasOne(d => d.MaintainGu)
                    .WithMany(p => p.MaintenanceManagementDetails)
                    .HasForeignKey(d => d.MaintainGuid)
                    .HasConstraintName("FK_MaintenanceManagementDetails_MaintenanceManagement");
            });

            modelBuilder.Entity<MaintenanceRequest>(entity =>
            {
                entity.HasKey(e => e.RowGuid);

                entity.ToTable("MaintenanceRequest", "Maintenance");

                entity.Property(e => e.RowGuid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ActualDate)
                    .HasColumnType("date")
                    .HasComment("Ngày bảo dưỡng thực tế");

                entity.Property(e => e.ActualTime).HasComment("Thời gian thực tế");

                entity.Property(e => e.Approve).HasComment("Duyệt phiếu bảo dưỡng ; 0 : chưa duyệt, 1 : Đã duyệt");

                entity.Property(e => e.ApproveStatus).HasComment("Duyệt phiếu cuả bộ phân sản xuất; 0 : chưa duyệt, 1 : Đã duyệt");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(50)
                    .HasColumnName("DeviceID")
                    .HasComment("mã thiết bị; Lấy ở mục chi tiết của kế hoạch năm");

                entity.Property(e => e.DeviceName).HasMaxLength(250);

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(50)
                    .HasColumnName("EmployeeID")
                    .HasComment("mã thiết bị; Lấy ở mục chi tiết của kế hoạch năm");

                entity.Property(e => e.MachineTypeId)
                    .HasMaxLength(255)
                    .HasComment("Loại bảo dưỡng");

                entity.Property(e => e.MaintainNumber)
                    .HasMaxLength(50)
                    .HasComment("Phiếu bảo dưỡng kế hoạch năm");

                entity.Property(e => e.MaintenanceRequestId)
                    .HasMaxLength(50)
                    .HasColumnName("MaintenanceRequestID")
                    .HasComment("Mã phiếu bảo dưỡng");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Note).HasMaxLength(250);

                entity.Property(e => e.OrganizationName).HasMaxLength(255);

                entity.Property(e => e.PlanTime).HasComment("Thời gian dự kiến");

                entity.Property(e => e.PlanType)
                    .HasMaxLength(255)
                    .HasComment("Loại kế hoạch 01 : bảo dưỡng ; 02 : Kiểm định định kỳ");

                entity.Property(e => e.ReceptionDate)
                    .HasColumnType("date")
                    .HasComment("Ngày tiếp nhận");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasComment("Ngày bảo dưỡng dự kiến");

                entity.Property(e => e.Year).HasComment("Năm sản xuất");
            });

            modelBuilder.Entity<MaintenanceRequestComment>(entity =>
            {
                entity.HasKey(e => e.CommentGuid)
                    .HasName("PK_MaintenanceRequestComments_1");

                entity.ToTable("MaintenanceRequestComments", "Maintenance");

                entity.Property(e => e.CommentGuid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AvatarUrl).HasMaxLength(255);

                entity.Property(e => e.Comment).HasComment("Nội dung comment");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DepartmentID");

                entity.Property(e => e.DepartmentName).HasMaxLength(50);

                entity.Property(e => e.EmployeeGuid).HasComment("Mã nhân viên thực hiện comment dạng Guid");

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID")
                    .HasComment("Mã nhân viên thực hiện comment dạng tự nhập");

                entity.Property(e => e.EmployeeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("Tên nhân viên");

                entity.Property(e => e.LoginName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasComment("Tên đăng nhập của người dùng tạo");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrganizationGuid).HasComment("Mã tổ chức dạng Guid, chỉ ra khách hàng thuộc tổ chức nào (nếu có)");

                entity.Property(e => e.ParentGuid).HasComment("Mã cha cho Comment. Mỗi comment chính sẽ có thể có các phản hồi tương ứng với comment đó");

                entity.Property(e => e.RecordGuid)
                    .HasDefaultValueSql("(newid())")
                    .HasComment("Mã bản ghi của các bảng tương ứng đẩy vào. Trường này đặt tên là RecordGuid nhằm đảm bảo việc viết lệnh hoặc store có cấu trúc chung.");
            });

            modelBuilder.Entity<MaintenanceRequestDetail>(entity =>
            {
                entity.HasKey(e => e.RowGuid);

                entity.ToTable("MaintenanceRequestDetails", "Maintenance");

                entity.Property(e => e.RowGuid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CriteriaTitle).HasMaxLength(255);

                entity.Property(e => e.Evaluate)
                    .HasMaxLength(255)
                    .HasComment("Đánh giá");

                entity.Property(e => e.JobDetails)
                    .HasMaxLength(255)
                    .HasComment("Chi tiết công việc");

                entity.Property(e => e.MaintenanceContentId).HasColumnName("MaintenanceContentID");

                entity.Property(e => e.MaintenanceRequestId)
                    .HasColumnName("MaintenanceRequestID")
                    .HasComment("ID của phiếu bảo dưỡng");

                entity.Property(e => e.MaterialCode)
                    .HasMaxLength(50)
                    .HasComment("mã vật tư");

                entity.Property(e => e.MethodType)
                    .HasMaxLength(255)
                    .HasComment("Phương pháp kiểm tra bảo dưỡng");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Note).HasMaxLength(250);

                entity.Property(e => e.Phenomena)
                    .HasMaxLength(255)
                    .HasComment("Hiện tượng");

                entity.Property(e => e.Quantity).HasComment("Số lượng");

                entity.Property(e => e.Results)
                    .HasMaxLength(50)
                    .HasComment("Kết quả");

                entity.Property(e => e.TotalMoney)
                    .HasColumnType("money")
                    .HasComment("Thành tiền");

                entity.Property(e => e.UnitMeasureId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("UnitMeasureID")
                    .HasComment("Đơn vị tính");

                entity.Property(e => e.UnitPrice)
                    .HasColumnType("money")
                    .HasComment("Đơn giá");

                entity.HasOne(d => d.MaintenanceRequest)
                    .WithMany(p => p.MaintenanceRequestDetails)
                    .HasForeignKey(d => d.MaintenanceRequestId)
                    .HasConstraintName("FK_MaintenanceRequestDetails_MaintenanceRequest");
            });

            modelBuilder.Entity<OriginWorkpiece>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationGuid, e.OriginId });

                entity.ToTable("OriginWorkpieces", "Common");

                entity.HasComment("Bảng danh mục gốc dao");

                entity.Property(e => e.OrganizationGuid).HasComment("Mã guid của đơn vị");

                entity.Property(e => e.OriginId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("OriginID")
                    .HasComment("Mã gốc phôi");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasComment("Mô tả (ví dụ: Z0 trên mặt)");

                entity.Property(e => e.ImageUrl).HasMaxLength(500);

                entity.Property(e => e.IsDefaultValue)
                    .HasDefaultValueSql("((0))")
                    .HasComment(" = 1 Là giá trị mặc định (sử dụng trên giao diện của các chức năng tham chiếu đến bảng này). = 0 Không là giá trị mặc định.");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RowGuid)
                    .HasDefaultValueSql("(newid())")
                    .HasComment("Mã guid tự sinh của bảng");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasComment("Tên gốc ");
            });

            modelBuilder.Entity<PlanCostLabor>(entity =>
            {
                entity.HasKey(e => e.RowGuid);

                entity.ToTable("PlanCostLabors", "Common");

                entity.HasComment("Danh mục phương án chi phí nhân công");

                entity.HasIndex(e => e.PlanMixCode, "UK_PlanCostLabors_Code")
                    .IsUnique();

                entity.Property(e => e.RowGuid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AppliedDate)
                    .HasColumnType("date")
                    .HasComment("Ngày áp dụng");

                entity.Property(e => e.Cost)
                    .HasColumnType("numeric(18, 2)")
                    .HasComment("Chi phí 1 sản phẩm");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasComment("Trạng thái");

                entity.Property(e => e.ItemId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Mã sản phẩm. Lấy từ Inventory.Items");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(250)
                    .HasComment("Tên sản phẩm. Lấy từ Inventory.Items");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasComment("Người sửa cuối cùng");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Note)
                    .HasMaxLength(250)
                    .HasComment("Ghi chú");

                entity.Property(e => e.OrganizationGuid).HasComment("Mã đơn vị");

                entity.Property(e => e.PartItemId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Mã bán thành phẩm. Lấy từ Inventory.Items");

                entity.Property(e => e.PartItemName)
                    .HasMaxLength(250)
                    .HasComment("Tên bán thành phẩm. Lấy từ Inventory.Items");

                entity.Property(e => e.PlanMixCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Mã code phương án");

                entity.Property(e => e.PlanMixName)
                    .HasMaxLength(250)
                    .HasComment("Tên phương án");

                entity.Property(e => e.Quantity)
                    .HasColumnType("numeric(18, 2)")
                    .HasComment("Sản lượng định mức");

                entity.Property(e => e.ShiftId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("Mã ca làm việc");

                entity.Property(e => e.ShiftName)
                    .HasMaxLength(50)
                    .HasComment("Tên ca làm việc");
            });

            modelBuilder.Entity<PlanMix>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationGuid, e.Code });

                entity.ToTable("PlanMix", "Common");

                entity.HasComment("Danh mục phương án trộn");

                entity.Property(e => e.OrganizationGuid).HasComment("Mã đơn vị");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Mã phương án trộn");

                entity.Property(e => e.Cost)
                    .HasColumnType("numeric(18, 2)")
                    .HasComment("Chi phí 1/kg trộn");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.GroupItemId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("GroupItemID");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasComment("Người sửa cuối cùng");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RowGuid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Title)
                    .HasMaxLength(250)
                    .HasComment("Tên phương án trộn");
            });

            modelBuilder.Entity<PlanMixDetail>(entity =>
            {
                entity.HasKey(e => e.RowGuid);

                entity.ToTable("PlanMixDetails", "Common");

                entity.HasComment("Chi tiết phương án trộn");

                entity.Property(e => e.RowGuid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ItemId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Mã vật tư. Lấy từ bảng VIETNHAT_AM.Inventory.Items");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasComment("Người sửa cuối cùng");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Note)
                    .HasMaxLength(250)
                    .HasComment("Ghi chú");

                entity.Property(e => e.OrganizationGuid).HasComment("Mã đơn vị");

                entity.Property(e => e.PartItemId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PartItemID")
                    .HasComment("Mã BTP. Lấy từ bảng VIETNHAT_AM.Inventory.Items");

                entity.Property(e => e.Percent)
                    .HasColumnType("numeric(18, 2)")
                    .HasComment("% tỷ lệ trộn");

                entity.Property(e => e.PercentNg)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("PercentNG")
                    .HasComment("Tỷ lệ hỏng");

                entity.Property(e => e.PlanMixCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Mã code phương án trộn");

                entity.Property(e => e.Quantity)
                    .HasColumnType("numeric(18, 2)")
                    .HasComment("KL tỷ lệ trộn");

                entity.Property(e => e.QuantityNet)
                    .HasColumnType("numeric(18, 2)")
                    .HasComment("Khôi slượng (chưa bao gồm tỷ lệ hỏng)");

                entity.Property(e => e.UnitGuid).HasComment("Mã guid đơn vị tính. Lấy từ bảng VIETNHAT_AM.Inventory.Items");

                entity.Property(e => e.UnitId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("Mã đơn vị tính. Lấy từ bảng VIETNHAT_AM.Inventory.Items");

                entity.Property(e => e.UnitName)
                    .HasMaxLength(50)
                    .HasComment("Tên đơn vị tính. Lấy từ bảng VIETNHAT_AM.Inventory.Items");

                entity.HasOne(d => d.PlanMix)
                    .WithMany(p => p.PlanMixDetails)
                    .HasForeignKey(d => new { d.OrganizationGuid, d.PlanMixCode })
                    .HasConstraintName("FK_PlanMixDetails_PlanMix");
            });

            modelBuilder.Entity<PlanResource>(entity =>
            {
                entity.HasKey(e => e.RowGuid);

                entity.ToTable("PlanResources", "Pro");

                entity.HasComment("Bảng nguồn lực cho kế hoạch sản xuất");

                entity.Property(e => e.RowGuid).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ImageUrl).HasMaxLength(500);

                entity.Property(e => e.InsuranceCost)
                    .HasColumnType("numeric(20, 2)")
                    .HasComment("Chi phí bảo hiểm công ty đóng");

                entity.Property(e => e.ItemId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ItemID")
                    .HasComment("Mã vật tư, vật liệu, bán thành phẩm");

                entity.Property(e => e.LaborCost)
                    .HasColumnType("numeric(20, 2)")
                    .HasComment("Chi phí lương nhân công");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.MachineCost)
                    .HasColumnType("numeric(20, 2)")
                    .HasComment("Chi phí máy.");

                entity.Property(e => e.MarchineId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MarchineID");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrganizationGuid).HasComment("Mã guid của đơn vị");

                entity.Property(e => e.PlanDayGuid).HasComment("Kế hoạch sản xuất đơn hàng sinh theo quy tắc");

                entity.Property(e => e.Quantity)
                    .HasColumnType("decimal(6, 2)")
                    .HasComment("Số lượng");

                entity.Property(e => e.QuantityNeed)
                    .HasColumnType("decimal(6, 2)")
                    .HasComment("Số lượng cần có để bắt đầu sản xuất");

                entity.Property(e => e.QuantityRequired)
                    .HasColumnType("decimal(6, 2)")
                    .HasComment("Số lượng yêu cầu để sản xuất đủ số lượng");

                entity.Property(e => e.Time).HasComment("Thời gian sản xuất (phút)");

                entity.Property(e => e.UnitId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UnitID")
                    .HasComment("Mã ID của Đơn vị tính chính");

                entity.Property(e => e.UnitName)
                    .HasMaxLength(25)
                    .HasComment("Tên của Đơn vị tính chính");

                entity.HasOne(d => d.PlanDayGu)
                    .WithMany(p => p.PlanResources)
                    .HasForeignKey(d => d.PlanDayGuid)
                    .HasConstraintName("FK_PlanResources_ProductionPlanDays");

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.PlanResources)
                    .HasForeignKey(d => new { d.OrganizationGuid, d.MarchineId })
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_PlanResources_PlanResources");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product", "Production");

                entity.HasComment("Sản phẩm bán hoặc được sử dụng trong việc sản xuất các sản phẩm bán");

                entity.HasIndex(e => e.Name, "AK_Product_Name")
                    .IsUnique();

                entity.HasIndex(e => e.ProductNumber, "AK_Product_ProductNumber")
                    .IsUnique();

                entity.HasIndex(e => e.Rowguid, "AK_Product_rowguid")
                    .IsUnique();

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .HasComment("Khóa chính cho bản ghi sản phẩm.");

                entity.Property(e => e.Class)
                    .HasMaxLength(2)
                    .IsFixedLength(true)
                    .HasComment("H = High, M = Medium, L = Low");

                entity.Property(e => e.Color)
                    .HasMaxLength(15)
                    .HasComment("Product color.");

                entity.Property(e => e.DaysToManufacture).HasComment("Number of days required to manufacture the product.");

                entity.Property(e => e.DiscontinuedDate)
                    .HasColumnType("datetime")
                    .HasComment("Date the product was discontinued.");

                entity.Property(e => e.FinishedGoodsFlag)
                    .IsRequired()
                    .HasDefaultValueSql("((1))")
                    .HasComment("0 = Product is not a salable item. 1 = Product is salable.");

                entity.Property(e => e.ListPrice)
                    .HasColumnType("money")
                    .HasComment("Selling price.");

                entity.Property(e => e.MakeFlag)
                    .IsRequired()
                    .HasDefaultValueSql("((1))")
                    .HasComment("0 = Product is purchased, 1 = Product is manufactured in-house.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Ngày và thời gian cập nhật bản ghi mới nhất.");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("Tên của sản phẩm");

                entity.Property(e => e.ProductLine)
                    .HasMaxLength(2)
                    .IsFixedLength(true)
                    .HasComment("R = Road, M = Mountain, T = Touring, S = Standard");

                entity.Property(e => e.ProductModelId)
                    .HasColumnName("ProductModelID")
                    .HasComment("Product is a member of this product model. Foreign key to ProductModel.ProductModelID.");

                entity.Property(e => e.ProductNumber)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasComment("Mã định danh sản phẩm.");

                entity.Property(e => e.ProductSubcategoryId)
                    .HasColumnName("ProductSubcategoryID")
                    .HasComment("Product is a member of this product subcategory. Foreign key to ProductSubCategory.ProductSubCategoryID. ");

                entity.Property(e => e.ReorderPoint).HasComment("Inventory level that triggers a purchase order or work order. ");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newid())")
                    .HasComment(" Mã định danh duy nhất của bản ghi. Sử dụng để hỗ trợ nhân bản, đồng bộ, gộp khi cần");

                entity.Property(e => e.SafetyStockLevel).HasComment("Minimum inventory quantity. ");

                entity.Property(e => e.SellEndDate)
                    .HasColumnType("datetime")
                    .HasComment("Date the product was no longer available for sale.");

                entity.Property(e => e.SellStartDate)
                    .HasColumnType("datetime")
                    .HasComment("Date the product was available for sale.");

                entity.Property(e => e.Size)
                    .HasMaxLength(5)
                    .HasComment("Product size.");

                entity.Property(e => e.SizeUnitMeasureCode)
                    .HasMaxLength(3)
                    .IsFixedLength(true)
                    .HasComment("Unit of measure for Size column.");

                entity.Property(e => e.StandardCost)
                    .HasColumnType("money")
                    .HasComment("Standard cost of the product.");

                entity.Property(e => e.Style)
                    .HasMaxLength(2)
                    .IsFixedLength(true)
                    .HasComment("W = Womens, M = Mens, U = Universal");

                entity.Property(e => e.Weight)
                    .HasColumnType("decimal(8, 2)")
                    .HasComment("Product weight.");

                entity.Property(e => e.WeightUnitMeasureCode)
                    .HasMaxLength(3)
                    .IsFixedLength(true)
                    .HasComment("Unit of measure for Weight column.");
            });

            modelBuilder.Entity<ProductCost>(entity =>
            {
                entity.HasKey(e => e.RowGuid);

                entity.ToTable("ProductCosts", "Pro");

                entity.HasComment("[Bảng tập hợp chi phí sản xuất]. Được tập hợp khi Nhân viên báo cáo kết quả công việc.");

                entity.Property(e => e.RowGuid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Amount)
                    .HasColumnType("numeric(20, 0)")
                    .HasComment("Số tiền");

                entity.Property(e => e.CostId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("CostID")
                    .HasComment("Mã chi phí. Tham chiếu bảng [Pro].[ProductCostNorms]");

                entity.Property(e => e.CostType)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasComment("Loại chi phí. \r\n= N là Chi phí nhân công, \r\n= M là Chi phí Máy, \r\n= G là Chi phí gia công ngoài, \r\n= C là Chi phí chung, \r\n= D là Chi phí CCDC\r\n= T là Chi phí Tài chính, Lãi vay\r\n= K là Chi phí khác\r\n= A là Chi phí Thất thoát\r\n= B là Chi phí Bao bì\r\n= X là Chi phí nhà xưởng");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasComment("Ngày của phiếu công việc sản xuất");

                entity.Property(e => e.FollowGuid)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsuranceCost)
                    .HasColumnType("numeric(20, 0)")
                    .HasComment("Chi phí bảo hiểm.");

                entity.Property(e => e.JobCardId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("JobCardID")
                    .HasComment("Mã công việc . Tham chiếu bảng [Pro].[JobCards]");

                entity.Property(e => e.OrderNumber)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasComment("Số đơn hàng");

                entity.Property(e => e.OrderPlanId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("OrderPlanID")
                    .HasComment("Mã lệnh sản xuất hoặc số Kế hoạch tổng");

                entity.Property(e => e.OrganizationGuid).HasComment("Mã guid của đơn vị");

                entity.Property(e => e.PartItemId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PartItemID")
                    .HasComment("Mã bán thành phẩm");

                entity.Property(e => e.ProductItemId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ProductItemID")
                    .HasComment("Mã Thành phẩm");

                entity.HasOne(d => d.JobCard)
                    .WithMany(p => p.ProductCosts)
                    .HasForeignKey(d => new { d.OrganizationGuid, d.JobCardId })
                    .HasConstraintName("FK_ProductCosts_JobCards");
            });

            modelBuilder.Entity<ProductCostHistory>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationGuid, e.OrderNumber, e.OrderPlanId, e.InternalOrderNo, e.ProductItemId, e.PartItemId, e.Date, e.CostType, e.LocationId });

                entity.ToTable("ProductCostHistories", "Pro");

                entity.HasComment("Lịch sử giá thành sản xuất thực tế");

                entity.Property(e => e.OrganizationGuid).HasComment("Mã guid của đơn vị");

                entity.Property(e => e.OrderNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Số đơn hàng (khách hàng).");

                entity.Property(e => e.OrderPlanId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OrderPlanID");

                entity.Property(e => e.InternalOrderNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Số đơn hàng (nội bộ)");

                entity.Property(e => e.ProductItemId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ProductItemID")
                    .HasComment("Mã thành phẩm. Tham chiếu từ bảng [Inventory].[Items] với tính chất là P-Thành phẩm. Tự động điền = [BOMCategories].ItemID khi chọn BOMNumber  ");

                entity.Property(e => e.PartItemId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PartItemID")
                    .HasComment("Mã bán thành phẩm");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasComment("Ngày phát sinh/ ngày nhập chi phí");

                entity.Property(e => e.CostType)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasComment("Loại chi phí.  = G Chi phí gia công ngoài, = C Chi phí sx chung, = T Chi phí tài chính, = A Chi phí thất thoát, = V Chi phí nguyên liệu - vật liệu, = N Chi phí nhân công, M - Chi phí sử dụng máy thi công, K - Chi phí khác");

                entity.Property(e => e.LocationId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("LocationID")
                    .HasComment("Công đoạn (quy trình công nghệ)");

                entity.Property(e => e.Amount)
                    .HasColumnType("numeric(20, 0)")
                    .HasComment("Số tiền phát sinh");

                entity.Property(e => e.AmountSurplus)
                    .HasColumnType("numeric(20, 0)")
                    .HasComment("Lũy kế tiền phát sinh");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.RowGuid)
                    .HasDefaultValueSql("(newid())")
                    .HasComment("Mã guid tự sinh của bảng");
            });

            modelBuilder.Entity<ProductCostNorm>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationGuid, e.Bomnumber, e.ProductItemId, e.PartItemId, e.CostId, e.Type });

                entity.ToTable("ProductCostNorms", "Pro");

                entity.HasComment("Định mức chi phí Gia công ngoài, Chi phí chung, Chi phí tài chính, Chi phí thất thoát, Chi phí khác của Thành phẩm, Bán thành phẩm.");

                entity.Property(e => e.OrganizationGuid).HasComment("Mã guid của đơn vị");

                entity.Property(e => e.Bomnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BOMNumber")
                    .HasComment("Mã BOM");

                entity.Property(e => e.ProductItemId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ProductItemID")
                    .HasComment("Mã thành phẩm. Tham chiếu từ bảng [Inventory].[Items] với tính chất là P-Thành phẩm. Tự động điền = [BOMCategories].ItemID khi chọn BOMNumber  ");

                entity.Property(e => e.PartItemId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PartItemID")
                    .HasComment("Mã bán thành phẩm (nếu có). Tham chiếu từ bảng [Inventory].[Items] với tính chất là B-Bán thành phẩm. Nếu chi phí không tính theo bán thành phẩm thì lưu PartIemID = rỗng");

                entity.Property(e => e.CostId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("CostID")
                    .HasComment("Mã chi phí. Tham chiếu bảng Common.CostNorms với điều kiện Tính chất = C - Mã chi tiết. Được lọc theo Loại chi phí.");

                entity.Property(e => e.Type)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Loại chi phí. \r\n= N là Chi phí nhân công, \r\n= M là Chi phí Máy, \r\n= G là Chi phí gia công ngoài, \r\n= C là Chi phí chung, \r\n= D là Chi phí CCDC\r\n= T là Chi phí Tài chính, Lãi vay\r\n= K là Chi phí khác\r\n= A là Chi phí Thất thoát\r\n= B là Chi phí Bao bì");

                entity.Property(e => e.Amount)
                    .HasColumnType("numeric(20, 0)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Giá trị định mức. Mặc định = Quantity * CostPrice. Người dùng có thể tự nhập");

                entity.Property(e => e.CostName)
                    .HasMaxLength(400)
                    .HasComment("Tên chi phí");

                entity.Property(e => e.CostPrice)
                    .HasColumnType("numeric(20, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Đơn giá định mức. Tự động lấy theo Đơn giá của bảng định mức CostNorms theo Mã chi phí. Người dùng có thể sửa lại giá trị khác.");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasComment("Người tạo");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(400)
                    .HasComment("Ghi chú (nếu có)");

                entity.Property(e => e.InsuranceCostPrice)
                    .HasColumnType("numeric(20, 2)")
                    .HasComment("Chi phí bảo hiểm công ty đóng (tính theo đvt là phút). Chỉ áp dụng đối với loại chi phí = Nhân công");

                entity.Property(e => e.IsBoldFont).HasComment("= 1 Kiểu chữ in đậm, = 0 Chữ không in đậm");

                entity.Property(e => e.IsItalicFont).HasComment("= 1 Kiểu chữ in nghiêng, = 0 Chữ không in nghiêng");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasComment("Người sửa");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Quantity)
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Số lượng định mức (nếu có). Nếu không có thì gán = 1");

                entity.Property(e => e.RowGuid)
                    .HasDefaultValueSql("(newid())")
                    .HasComment("Mã Guid tự sinh của bảng");

                entity.Property(e => e.SortOrder).HasComment("Thứ tự sắp xếp");

                entity.Property(e => e.UnitId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UnitID")
                    .HasComment("Mã đvt. Tham chiếu bảng [ES_AM].[Common].[Units]");

                entity.Property(e => e.UnitName)
                    .HasMaxLength(50)
                    .HasComment("Tên đơn vị tính");

                entity.HasOne(d => d.Bomcategory)
                    .WithMany(p => p.ProductCostNorms)
                    .HasForeignKey(d => new { d.OrganizationGuid, d.Bomnumber })
                    .HasConstraintName("FK_ProductCostNorms_BOMCategories");
            });

            modelBuilder.Entity<ProductDescription>(entity =>
            {
                entity.ToTable("ProductDescription", "Production");

                entity.HasComment("Mô tả sản phẩm theo các ngôn ngữ khác nhau.");

                entity.HasIndex(e => e.Rowguid, "AK_ProductDescription_rowguid")
                    .IsUnique();

                entity.Property(e => e.ProductDescriptionId)
                    .HasColumnName("ProductDescriptionID")
                    .HasComment("Khóa chính cho các bản ghi bảng ProductDescription.");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(400)
                    .HasComment("Mô tả về sản phẩm.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasComment("Ngày và thời gian cập nhật bản ghi mới nhất.");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasComment(" Mã định danh duy nhất của bản ghi. Sử dụng để hỗ trợ nhân bản, đồng bộ, gộp khi cần");
            });

            modelBuilder.Entity<ProductModel>(entity =>
            {
                entity.ToTable("ProductModel", "Production");

                entity.HasComment("Phân loại mô hình sản phẩm.");

                entity.HasIndex(e => e.Name, "AK_ProductModel_Name")
                    .IsUnique();

                entity.HasIndex(e => e.Rowguid, "AK_ProductModel_rowguid")
                    .IsUnique();

                entity.HasIndex(e => e.CatalogDescription, "PXML_ProductModel_CatalogDescription");

                entity.HasIndex(e => e.Instructions, "PXML_ProductModel_Instructions");

                entity.Property(e => e.ProductModelId)
                    .HasColumnName("ProductModelID")
                    .HasComment("Khóa chính cho các bản ghi bảng ProductModel.");

                entity.Property(e => e.CatalogDescription)
                    .HasColumnType("xml")
                    .HasComment("Danh mục chi tiết thông tin chi tiết sản phẩm định dạng XML hoặ JSON.");

                entity.Property(e => e.Instructions)
                    .HasColumnType("xml")
                    .HasComment("Chỉ dẫn sản xuất theo định dạng XML hoặc JSON.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Ngày và thời gian cập nhật bản ghi mới nhất.");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("Mô tả Model sản phẩm.");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newid())")
                    .HasComment(" Mã định danh duy nhất của bản ghi. Sử dụng để hỗ trợ nhân bản, đồng bộ, gộp khi cần");
            });

            modelBuilder.Entity<ProductModelProductDescriptionCulture>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ProductModelProductDescriptionCulture", "Production");

                entity.HasComment("Bảng tham chiếu chéo giữa mô tả sản phẩm và ngôn ngữ.");

                entity.Property(e => e.CultureId)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasColumnName("CultureID")
                    .IsFixedLength(true)
                    .HasComment("Số định danh Culture. khóa ngoài cho Culture.CultureID.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasComment("Ngày và thời gian cập nhật bản ghi mới nhất.");

                entity.Property(e => e.ProductDescriptionId)
                    .HasColumnName("ProductDescriptionID")
                    .HasComment("Khóa chính. Khóa ngoài cho  ProductDescription.ProductDescriptionID.");

                entity.Property(e => e.ProductModelId)
                    .HasColumnName("ProductModelID")
                    .HasComment("Khóa chính. Khóa ngoài cho ProductModel.ProductModelID.");
            });

            modelBuilder.Entity<ProductSpecification>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationGuid, e.LotNumber, e.AttributeId, e.SortOrder });

                entity.ToTable("ProductSpecifications", "Pro");

                entity.HasComment("Thông số, quy cách của thành phẩm, vật tư, hàng hóa.");

                entity.Property(e => e.OrganizationGuid).HasComment("Mã guid của đơn vị");

                entity.Property(e => e.LotNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Số lô sản xuất");

                entity.Property(e => e.AttributeId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AttributeID")
                    .HasComment("Mã thuộc tính. Tham chiếu bảng [ES_AM].[Inventory].[Attributes]");

                entity.Property(e => e.SortOrder).HasComment("Thứ tự sắp xếp của thuộc tính (tính theo từng ItemID)");

                entity.Property(e => e.AttributeName)
                    .HasMaxLength(250)
                    .HasComment("Tên thuộc tính (tên quy cách)");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasComment("Người tạo");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DisplayValue)
                    .HasMaxLength(400)
                    .HasComment("Giá trị hiển thị, giá trị của thuộc tính.");

                entity.Property(e => e.ItemId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ItemID")
                    .HasComment("Mã thành phẩm. Tham chiếu bảng danh mục thành phẩm (ES_AM.Inventory.Items)");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(255)
                    .HasComment("Tên thành phẩm");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasComment("Người sửa");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RowGuid)
                    .HasDefaultValueSql("(newid())")
                    .HasComment("Mã guid tự sinh của bảng.");

                entity.Property(e => e.SelectedValue)
                    .HasMaxLength(50)
                    .HasComment("Giá trị được chọn. Chỉ áp dụng đối với những mã thuộc tính có loại là Chọn giá trị");

                entity.HasOne(d => d.LotNumberNavigation)
                    .WithMany(p => p.ProductSpecifications)
                    .HasForeignKey(d => new { d.OrganizationGuid, d.LotNumber })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductSpecifications_LotNumbers");
            });

            modelBuilder.Entity<ProductionPlan>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationGuid, e.OrderPlanId });

                entity.ToTable("ProductionPlans", "Pro");

                entity.HasComment("Kế hoạch sản xuất tổng");

                entity.Property(e => e.OrganizationGuid).HasComment("Mã guid của đơn vị");

                entity.Property(e => e.OrderPlanId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("OrderPlanID")
                    .HasComment("Kế hoạch sản xuất đơn hàng sinh theo quy tắc");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(50)
                    .HasComment("Tên người duyệt kế hoạch.");

                entity.Property(e => e.ApprovedDate)
                    .HasColumnType("datetime")
                    .HasComment("Ngày duyệt");

                entity.Property(e => e.ApprovedNote)
                    .HasMaxLength(500)
                    .HasComment("Nội dung duyệt phiếu");

                entity.Property(e => e.Bomnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BOMNumber")
                    .HasComment("Mã BOM. Tham chiếu bảng [Pro].[BOMCategories]");

                entity.Property(e => e.CancelDate)
                    .HasColumnType("datetime")
                    .HasComment("Ngày hủy kế hoạch");

                entity.Property(e => e.CancelName)
                    .HasMaxLength(250)
                    .HasComment("Người hủy kế hoạch");

                entity.Property(e => e.CancelReason)
                    .HasMaxLength(500)
                    .HasComment("Lý do hủy kế hoạch");

                entity.Property(e => e.Cavity).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Cof)
                    .HasMaxLength(250)
                    .HasColumnName("COF")
                    .HasComment("Khác hàng");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CycTime).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .HasComment("Ghi chú (nếu có)");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID")
                    .HasComment("Mã nhân viên lập kế hoạch. Tham chiếu bảng ES_AM.Common.Objects với đk IsEmployee = 1");

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(50)
                    .HasComment("Tên nhân viên lập kế hoạch");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasComment("Ngày kết thúc kế hoạch");

                entity.Property(e => e.IsCancel).HasComment("Trạng thái hủy kế hoạch: 1 - Hủy. 0 - Không hủy");

                entity.Property(e => e.ItemId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ItemID")
                    .HasComment("Mã Thành phẩm sản xuất (Mã nội bộ). Tham chiếu bảng ES_AM.Inventory.Items");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(255)
                    .HasComment("Tên thành phẩm (tên sản phẩm nội bộ)");

                entity.Property(e => e.LastStock)
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("Số lượng tồn kho cuối");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Ngày và thời gian bản ghi được cập nhật.");

                entity.Property(e => e.Note).HasMaxLength(250);

                entity.Property(e => e.OrderDetailGuid).HasComment("Chi tiết đơn đặt hàng. tham chiếu bảng ES_AM.[Sale].[OrderDetails]");

                entity.Property(e => e.OrderItemId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("OrderItemID")
                    .HasComment("Mã sản phẩm khách hàng đặt hàng. Tự động điền khi chọn từ chi tiết Đơn đặt hàng (có OrderDetailGuid). ");

                entity.Property(e => e.OrderNumber)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasComment("Số đơn đặt hàng. Tham chiếu bảng [ES_AM].[Sale].[Orders]");

                entity.Property(e => e.PartName)
                    .HasMaxLength(250)
                    .HasComment("Tên sản phẩm");

                entity.Property(e => e.PartNo)
                    .HasMaxLength(50)
                    .HasComment("Mã sản phẩm");

                entity.Property(e => e.ProOrderProductGuid).HasComment("Mã guid Chi tiết lệnh sản xuất. tham chiếu bảng ES_AM.[Inventory].[ProductionOrderProducts]");

                entity.Property(e => e.ProductionOrderNo)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasComment("Số lệnh sản xuất (nếu lập kế hoạch từ Chi tiết lệnh sản xuất). Tham chiếu bảng [Inventory].[ProductionOrders]");

                entity.Property(e => e.Quantity)
                    .HasColumnType("numeric(20, 2)")
                    .HasComment("SL sản xuất theo kế hoạch.");

                entity.Property(e => e.RowGuid)
                    .HasDefaultValueSql("(newid())")
                    .HasComment("Mã guid tự sinh của bảng");

                entity.Property(e => e.RunNumber).HasComment("thứ tự của kế hoạch (trên cùng 1 đơn hàng)");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasComment("Ngày bắt đầu kế hoạch");

                entity.Property(e => e.Status).HasComment("Trạng thái duyệt kế hoạch. = 1 Đã duyệt, = 2 Không duyệt, = 0 Chưa duyệt");

                entity.Property(e => e.UnitId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("UnitID")
                    .HasComment("Mã ĐVT chính của thành phẩm sx.");
            });

            modelBuilder.Entity<ProductionPlanDay>(entity =>
            {
                entity.HasKey(e => e.PlanDayGuid);

                entity.ToTable("ProductionPlanDays", "Pro");

                entity.HasComment("Kế hoạch sản xuất ngày");

                entity.Property(e => e.PlanDayGuid)
                    .HasDefaultValueSql("(newid())")
                    .HasComment("Mã guid tự sinh của bảng.");

                entity.Property(e => e.Bomnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BOMNumber")
                    .HasComment("Mã BOM. Tham chiếu bảng [Pro].[BOMCategories]. Tự động điền từ kế  hoạch tổng [Pro].[ProductionPlans]");

                entity.Property(e => e.CamSheetGuid).HasComment("Mã guid CamSheet. tham chiếu bảng [Pro].[BOMCamSheets]");

                entity.Property(e => e.CamSheetId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("CamSheetID")
                    .HasComment("Mã Camsheet. Tham chiếu bảng [Pro].[BOMCamSheets]. ");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CycleTime).HasComment("Chu kỳ / giờ");

                entity.Property(e => e.EndTime).HasColumnType("time(0)");

                entity.Property(e => e.IsPause).HasComment("Trạng thái dừng kế hoạch: 1 - Dừng. 0 - Không dừng");

                entity.Property(e => e.ItemId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ItemID")
                    .HasComment("Mã Thành phẩm sản xuất (Mã nội bộ). Tham chiếu bảng ES_AM.Inventory.Items");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(255)
                    .HasComment("Tên thành phẩm (tên sản phẩm nội bộ)");

                entity.Property(e => e.LocationId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("LocationID")
                    .HasComment("Mã quy trình công nghệ. Tham chiếu bảng Common.Locations.");

                entity.Property(e => e.LocationName)
                    .HasMaxLength(250)
                    .HasComment("Tên quy trình công nghệ.");

                entity.Property(e => e.LotNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Số lô sx. Tham chiếu bảng [Pro].[LotNumbers]");

                entity.Property(e => e.MachineId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("MachineID")
                    .HasComment("Mã máy - nguồn lực sx. Tham chiếu bảng [Common].[Machines]");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Ngày và thời gian bản ghi được cập nhật.");

                entity.Property(e => e.MoldCode)
                    .HasMaxLength(50)
                    .HasComment("Mã khuôn");

                entity.Property(e => e.MoldTime)
                    .HasMaxLength(150)
                    .HasComment("Thời gian lên khuôn");

                entity.Property(e => e.Note).HasMaxLength(250);

                entity.Property(e => e.OrderDetailGuid).HasComment("Chi tiết đơn đặt hàng. tham chiếu bảng ES_AM.[Sale].[OrderDetails]. Tự động điền từ kế  hoạch tổng [Pro].[ProductionPlans]");

                entity.Property(e => e.OrderItemId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("OrderItemID")
                    .HasComment("Mã sản phẩm khách hàng đặt hàng. Tự động điền từ kế hoạch tổng [Pro].[ProductionPlans]");

                entity.Property(e => e.OrderNumber)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasComment("Số đơn đặt hàng. Tham chiếu bảng [ES_AM].[Sale].[Orders]. Tự động điền từ kế  hoạch tổng [Pro].[ProductionPlans]");

                entity.Property(e => e.OrderPlanDay)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Mã công việc theo ngày");

                entity.Property(e => e.OrderPlanId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("OrderPlanID")
                    .HasComment("Mã KH đơn hàng. Tham chiếu bảng kế hoạch tổng [Pro].[ProductionPlans]");

                entity.Property(e => e.OrganizationGuid).HasComment("Mã guid của đơn vị");

                entity.Property(e => e.PartItemId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PartItemID")
                    .HasComment("Mã bán thành phẩm. Tham chiếu từ bảng [Inventory].[Items] với tính chất là B-Bán thành phẩm. Khi Loại Type khác 'B' thì lưu giá trị = rỗng");

                entity.Property(e => e.PartItemName)
                    .HasMaxLength(500)
                    .HasComment("Tên bán thành phẩm");

                entity.Property(e => e.PauseName)
                    .HasMaxLength(50)
                    .HasComment("Người yêu cầu dừng");

                entity.Property(e => e.PauseNote)
                    .HasMaxLength(500)
                    .HasComment("Lý do dừng kế hoạch");

                entity.Property(e => e.PlanDate)
                    .HasColumnType("date")
                    .HasComment("Ngày sản xuất (kế hoạch). Phải nằm trong khoảng thời gian ngày bắt đầu kế hoạch --> ngày kết thúc kế hoạch của kế hoạch tổng");

                entity.Property(e => e.ProOrderProductGuid).HasComment("Mã guid Chi tiết lệnh sản xuất. tham chiếu bảng ES_AM.[Inventory].[ProductionOrderProducts]. Tự động điền từ kế  hoạch tổng [Pro].[ProductionPlans]");

                entity.Property(e => e.ProductionOrderNo)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasComment("Số lệnh sản xuất (nếu lập kế hoạch từ Chi tiết lệnh sản xuất). Tự động điền từ kế hoạch tổng [Pro].[ProductionPlans]");

                entity.Property(e => e.ProductionTime).HasComment("TG SX cần");

                entity.Property(e => e.ProductionTime3).HasComment("Số giờ chạy máy ca 3");

                entity.Property(e => e.Quantity)
                    .HasColumnType("numeric(20, 2)")
                    .HasComment("Số lượng cần ca 1");

                entity.Property(e => e.Quantity3)
                    .HasColumnType("numeric(20, 2)")
                    .HasComment("Số lượng cần ca 3");

                entity.Property(e => e.QuantityHourse)
                    .HasColumnType("numeric(20, 2)")
                    .HasComment("Số lượng/ giờ");

                entity.Property(e => e.QuantityNg)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("QuantityNG");

                entity.Property(e => e.QuantityOk)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("QuantityOK")
                    .HasComment("Số lượng OK");

                entity.Property(e => e.QuantityTest).HasColumnType("numeric(20, 2)");

                entity.Property(e => e.RunNumber).HasComment("Số chạy tự tăng của công việc");

                entity.Property(e => e.StartTime).HasColumnType("time(0)");

                entity.Property(e => e.UnitId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UnitID")
                    .HasComment("Mã ID của Đơn vị tính chính. Tự động điền từ kế  hoạch tổng [Pro].[ProductionPlans]");

                entity.Property(e => e.UnitName)
                    .HasMaxLength(25)
                    .HasComment("Tên của Đơn vị tính chính");

                entity.Property(e => e.WoroutingGuid)
                    .HasColumnName("WORoutingGuid")
                    .HasComment("Mã guid BOM quy trình công nghệ sx BTP, TP. Tham chiếu bảng [Pro].[BOMWorkOrderRoutings]");

                entity.HasOne(d => d.HeaderGu)
                    .WithMany(p => p.ProductionPlanDays)
                    .HasForeignKey(d => d.HeaderGuid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ProductionPlanDays_ProductionPlanDayHeaders");

                entity.HasOne(d => d.Or)
                    .WithMany(p => p.ProductionPlanDays)
                    .HasForeignKey(d => new { d.OrganizationGuid, d.OrderPlanId })
                    .HasConstraintName("FK_ProductionPlanDays_ProductionPlans");
            });

            modelBuilder.Entity<ProductionPlanDayHeader>(entity =>
            {
                entity.HasKey(e => e.RowGuid);

                entity.ToTable("ProductionPlanDayHeaders", "Pro");

                entity.Property(e => e.RowGuid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EmployeeId).HasMaxLength(50);

                entity.Property(e => e.EmployeeName).HasMaxLength(250);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Ngày và thời gian bản ghi được cập nhật.");

                entity.Property(e => e.OrderPlanId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OrderPlanID");

                entity.Property(e => e.PlanDate).HasColumnType("date");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Title).HasMaxLength(250);
            });

            modelBuilder.Entity<ProductionPlansDetail>(entity =>
            {
                entity.HasKey(e => e.RowGuid);

                entity.ToTable("ProductionPlansDetails", "Pro");

                entity.Property(e => e.RowGuid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Bomnumber)
                    .HasMaxLength(50)
                    .HasColumnName("BOMNumber");

                entity.Property(e => e.Cavity).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Cof)
                    .HasMaxLength(250)
                    .HasColumnName("COF")
                    .HasComment("Khác hàng");

                entity.Property(e => e.CycTime).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Dh1)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DH_1");

                entity.Property(e => e.Dh10)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DH_10");

                entity.Property(e => e.Dh11)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DH_11");

                entity.Property(e => e.Dh12)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DH_12");

                entity.Property(e => e.Dh13)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DH_13");

                entity.Property(e => e.Dh14)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DH_14");

                entity.Property(e => e.Dh15)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DH_15");

                entity.Property(e => e.Dh16)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DH_16");

                entity.Property(e => e.Dh17)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DH_17");

                entity.Property(e => e.Dh18)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DH_18");

                entity.Property(e => e.Dh19)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DH_19");

                entity.Property(e => e.Dh2)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DH_2");

                entity.Property(e => e.Dh20)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DH_20");

                entity.Property(e => e.Dh21)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DH_21");

                entity.Property(e => e.Dh22)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DH_22");

                entity.Property(e => e.Dh23)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DH_23");

                entity.Property(e => e.Dh24)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DH_24");

                entity.Property(e => e.Dh25)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DH_25");

                entity.Property(e => e.Dh26)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DH_26");

                entity.Property(e => e.Dh27)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DH_27");

                entity.Property(e => e.Dh28)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DH_28");

                entity.Property(e => e.Dh29)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DH_29");

                entity.Property(e => e.Dh3)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DH_3");

                entity.Property(e => e.Dh30)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DH_30");

                entity.Property(e => e.Dh31)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DH_31");

                entity.Property(e => e.Dh4)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DH_4");

                entity.Property(e => e.Dh5)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DH_5");

                entity.Property(e => e.Dh6)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DH_6");

                entity.Property(e => e.Dh7)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DH_7");

                entity.Property(e => e.Dh8)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DH_8");

                entity.Property(e => e.Dh9)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("DH_9");

                entity.Property(e => e.Kh1)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("KH_1");

                entity.Property(e => e.Kh10)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("KH_10");

                entity.Property(e => e.Kh11)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("KH_11");

                entity.Property(e => e.Kh12)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("KH_12");

                entity.Property(e => e.Kh13)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("KH_13");

                entity.Property(e => e.Kh14)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("KH_14");

                entity.Property(e => e.Kh15)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("KH_15");

                entity.Property(e => e.Kh16)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("KH_16");

                entity.Property(e => e.Kh17)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("KH_17");

                entity.Property(e => e.Kh18)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("KH_18");

                entity.Property(e => e.Kh19)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("KH_19");

                entity.Property(e => e.Kh2)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("KH_2");

                entity.Property(e => e.Kh20)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("KH_20");

                entity.Property(e => e.Kh21)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("KH_21");

                entity.Property(e => e.Kh22)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("KH_22");

                entity.Property(e => e.Kh23)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("KH_23");

                entity.Property(e => e.Kh24)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("KH_24");

                entity.Property(e => e.Kh25)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("KH_25");

                entity.Property(e => e.Kh26)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("KH_26");

                entity.Property(e => e.Kh27)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("KH_27");

                entity.Property(e => e.Kh28)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("KH_28");

                entity.Property(e => e.Kh29)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("KH_29");

                entity.Property(e => e.Kh3)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("KH_3");

                entity.Property(e => e.Kh30)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("KH_30");

                entity.Property(e => e.Kh31)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("KH_31");

                entity.Property(e => e.Kh4)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("KH_4");

                entity.Property(e => e.Kh5)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("KH_5");

                entity.Property(e => e.Kh6)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("KH_6");

                entity.Property(e => e.Kh7)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("KH_7");

                entity.Property(e => e.Kh8)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("KH_8");

                entity.Property(e => e.Kh9)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("KH_9");

                entity.Property(e => e.LastStock)
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("Số lượng tồn kho cuối");

                entity.Property(e => e.May)
                    .HasMaxLength(50)
                    .HasColumnName("MAY");

                entity.Property(e => e.OrderPlanId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("OrderPlanID")
                    .HasComment("Số kế hoạch tổng");

                entity.Property(e => e.PartName)
                    .HasMaxLength(250)
                    .HasComment("Tên sản phẩm");

                entity.Property(e => e.PartNo)
                    .HasMaxLength(50)
                    .HasComment("Mã sản phẩm");

                entity.Property(e => e.Tk1)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("TK_1");

                entity.Property(e => e.Tk10)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("TK_10");

                entity.Property(e => e.Tk11)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("TK_11");

                entity.Property(e => e.Tk12)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("TK_12");

                entity.Property(e => e.Tk13)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("TK_13");

                entity.Property(e => e.Tk14)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("TK_14");

                entity.Property(e => e.Tk15)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("TK_15");

                entity.Property(e => e.Tk16)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("TK_16");

                entity.Property(e => e.Tk17)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("TK_17");

                entity.Property(e => e.Tk18)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("TK_18");

                entity.Property(e => e.Tk19)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("TK_19");

                entity.Property(e => e.Tk2)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("TK_2");

                entity.Property(e => e.Tk20)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("TK_20");

                entity.Property(e => e.Tk21)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("TK_21");

                entity.Property(e => e.Tk22)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("TK_22");

                entity.Property(e => e.Tk23)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("TK_23");

                entity.Property(e => e.Tk24)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("TK_24");

                entity.Property(e => e.Tk25)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("TK_25");

                entity.Property(e => e.Tk26)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("TK_26");

                entity.Property(e => e.Tk27)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("TK_27");

                entity.Property(e => e.Tk28)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("TK_28");

                entity.Property(e => e.Tk29)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("TK_29");

                entity.Property(e => e.Tk3)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("TK_3");

                entity.Property(e => e.Tk30)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("TK_30");

                entity.Property(e => e.Tk31)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("TK_31");

                entity.Property(e => e.Tk4)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("TK_4");

                entity.Property(e => e.Tk5)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("TK_5");

                entity.Property(e => e.Tk6)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("TK_6");

                entity.Property(e => e.Tk7)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("TK_7");

                entity.Property(e => e.Tk8)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("TK_8");

                entity.Property(e => e.Tk9)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("TK_9");

                entity.Property(e => e.Type)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("Loại: DH - Đơn hàng. KH - Kế hoạch. GL - Giờ làm. TK - Tồn kho.");
            });

            modelBuilder.Entity<RecommendInspection>(entity =>
            {
                entity.HasKey(e => e.RowGuid);

                entity.ToTable("RecommendInspection", "Maintenance");

                entity.HasComment("Đề nghị kiểm định");

                entity.Property(e => e.RowGuid).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .HasComment("Mã số phiếu");

                entity.Property(e => e.ConditionValue).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DepartmentGuid).HasComment("Phòng ban đề nghị");

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(250)
                    .HasComment("Tên Phòng ban");

                entity.Property(e => e.EmployeeGuid).HasComment("Người đề nghị");

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(250)
                    .HasComment("Tên Người đề nghị");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Purpose)
                    .HasMaxLength(250)
                    .HasComment("Mục đích đề  nghị");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Trạng thái");

                entity.Property(e => e.SuggestedDate)
                    .HasColumnType("date")
                    .HasComment("Ngày đề nghị");
            });

            modelBuilder.Entity<RecommendInspectionComment>(entity =>
            {
                entity.HasKey(e => e.CommentGuid);

                entity.ToTable("RecommendInspectionComments", "Maintenance");

                entity.HasComment("Bảng comment của đề nghị kiểm định");

                entity.Property(e => e.CommentGuid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AvatarUrl)
                    .HasMaxLength(255)
                    .HasComment("Đường dẫn ảnh đại diện của user");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasComment("Nội dung bình luận");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DepartmentID");

                entity.Property(e => e.DepartmentName).HasMaxLength(50);

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID")
                    .HasComment("Mã nhân viên ( nhân viên comment)");

                entity.Property(e => e.EmployeeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LoginName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasComment("Tên đăng nhập của người dùng tạo");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OrganizationGuid).HasComment("Mã tổ chức dạng Guid, chỉ ra khách hàng thuộc tổ chức nào (nếu có)");

                entity.Property(e => e.ParentGuid).HasComment("Mã cha cho Comment. Mỗi comment chính sẽ có thể có các phản hồi tương ứng với comment đó");

                entity.Property(e => e.RecordGuid)
                    .HasDefaultValueSql("(newid())")
                    .HasComment("Mã bản ghi của các bảng tương ứng đẩy vào. Trường này đặt tên là RecordGuid nhằm đảm bảo việc viết lệnh hoặc store có cấu trúc chung.");
            });

            modelBuilder.Entity<RecommendInspectionDetail>(entity =>
            {
                entity.HasKey(e => e.RowGuid);

                entity.ToTable("RecommendInspectionDetails", "Maintenance");

                entity.HasComment("Bảng chi tiết của đề nghị kiểm định");

                entity.Property(e => e.RowGuid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Amount)
                    .HasColumnType("money")
                    .HasComment("Thành tiền");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(50)
                    .HasColumnName("DeviceID")
                    .HasComment("Mã thiết bị");

                entity.Property(e => e.DeviceName)
                    .HasMaxLength(250)
                    .HasComment("Tên thiết bị");

                entity.Property(e => e.ExpectedDate)
                    .HasColumnType("date")
                    .HasComment("Ngày kiểm định dự kiến");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Unit)
                    .HasMaxLength(250)
                    .HasComment("Đơn vị");

                entity.Property(e => e.UnitPrice)
                    .HasColumnType("money")
                    .HasComment("Đơn giá dự kiến");
            });

            modelBuilder.Entity<RecommendInspectionProcess>(entity =>
            {
                entity.HasKey(e => e.RowGuid);

                entity.ToTable("RecommendInspectionProcess", "Maintenance");

                entity.HasComment("Bảng lưu các bước duyệt của đề nghị kiểm định");

                entity.Property(e => e.RowGuid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ActionName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("Tên hành động xử lý (Lấy thông tin theo định nghĩa của quy trình xử lý) hoặc theo Form thiết kế (nếu không sử dụng quy trình)");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasComment("Nội dung ý kiến xử lý.");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DepartmentGuid).HasComment("Mã phòng ban, bộ phận dạng Guid");

                entity.Property(e => e.DepartmentId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DepartmentID")
                    .HasComment("Mã phòng ban, bộ phận dạng tự nhập");

                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasComment("Tên phòng ban");

                entity.Property(e => e.EmployeeGuid).HasComment("Mã nhân viên xử lý dạng Guid");

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID")
                    .HasComment("Mã nhân viên xử lý dạng tự nhập");

                entity.Property(e => e.EmployeeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("Tên nhân viên xử lý");

                entity.Property(e => e.JobTitleName)
                    .HasMaxLength(50)
                    .HasComment("Tên chức danh người xử lý");

                entity.Property(e => e.LoginName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Tên đăng nhập của người dùng tạo");

                entity.Property(e => e.OrganizationGuid).HasComment("Mã tổ chức đơn vị của nhân viên");

                entity.Property(e => e.RecordGuid).HasComment("Mã khóa chính của ApplyLeaves");

                entity.Property(e => e.WfstatusId)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("WFStatusID")
                    .HasComment("Trạng thái Workflow của từng bước trong quy trình");

                entity.Property(e => e.WorkFlowCurrent).HasComment("Mã bước hiện tại mà phiếu đang quản lý. Trường này nhằm xác định phiếu đang ở bước nào trong quy trình và trên cơ sở đó sẽ xác định được các bước đi tiếp theo dựa vào điều kiện trong sơ đồ của quy trình");
            });

            modelBuilder.Entity<SaleBomcamSheet>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationGuid, e.Bomnumber, e.ProductItemId, e.PartItemId, e.LocationId, e.CamSheetId })
                    .HasName("PK_BOMCamSheets");

                entity.ToTable("SaleBOMCamSheets", "Pro_Sale");

                entity.HasComment("Định mức nguyên công (lập trình CamSheet) của quy trình công nghệ có Lập trình sản xuất thành phẩm, bán thành phẩm.");

                entity.Property(e => e.OrganizationGuid).HasComment("Mã guid của đơn vị");

                entity.Property(e => e.Bomnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BOMNumber")
                    .HasComment("Mã BOM");

                entity.Property(e => e.ProductItemId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ProductItemID")
                    .HasComment("Mã thành phẩm. Tham chiếu từ bảng [Inventory].[Items] với tính chất là P-Thành phẩm. Tự động điền = [BOMCategories].ItemID khi chọn BOMNumber  ");

                entity.Property(e => e.PartItemId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PartItemID")
                    .HasComment("Mã bán thành phẩm. Tham chiếu từ bảng [Inventory].[Items] với tính chất là B-Bán thành phẩm. Khi Loại Type khác 'B' thì lưu giá trị = rỗng");

                entity.Property(e => e.LocationId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("LocationID")
                    .HasComment("Mã quy trình công nghệ. Tham chiếu bảng Common.Locations.");

                entity.Property(e => e.CamSheetId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("CamSheetID")
                    .HasComment("Mã Camsheet.");

                entity.Property(e => e.ApprovedDate).HasColumnType("date");

                entity.Property(e => e.ApprovedName).HasMaxLength(250);

                entity.Property(e => e.BoworGuid)
                    .HasColumnName("BOWorGuid")
                    .HasComment("danh sách guid của công đoạn");

                entity.Property(e => e.CamSheetDate)
                    .HasColumnType("date")
                    .HasComment("Ngày bàn giao");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .HasComment("Mô tả, ghi chú khi cần");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID")
                    .HasComment("Mã nhân viên Lập trình. Tham chiếu bảng ES_HR.[HR].[Employees]");

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(50)
                    .HasComment("Tên nhân viên lập trình");

                entity.Property(e => e.MachineTime)
                    .HasColumnType("numeric(18, 2)")
                    .HasComment("Machine Time");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasComment("Ngày và thời gian bản ghi được cập nhật.");

                entity.Property(e => e.OriginId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("OriginID")
                    .HasComment("Mã gốc phôi. Tham chiếu bảng [Common].[OriginWorkpieces]");

                entity.Property(e => e.RowGuid).HasComment("Mã guid tự sinh của bảng");

                entity.Property(e => e.SetupTime)
                    .HasColumnType("numeric(18, 2)")
                    .HasComment("Setup Time");

                entity.Property(e => e.SortOrder).HasComment("Thứ tự sắp xếp nếu có");

                entity.Property(e => e.UrlImage).HasMaxLength(250);

                entity.Property(e => e.WorkpieceQuantity)
                    .HasColumnType("numeric(18, 2)")
                    .HasComment("SP/Phôi");

                entity.HasOne(d => d.SaleBomcategory)
                    .WithMany(p => p.SaleBomcamSheets)
                    .HasForeignKey(d => new { d.OrganizationGuid, d.Bomnumber })
                    .HasConstraintName("FK_BOMCamSheets_BOMCategories");
            });

            modelBuilder.Entity<SaleBomcamSheetSetting>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationGuid, e.Bomnumber, e.ProductItemId, e.PartItemId, e.LocationId, e.CamSheetId, e.KnifeId })
                    .HasName("PK_BOMCamSheetSettings");

                entity.ToTable("SaleBOMCamSheetSettings", "Pro_Sale");

                entity.HasComment("Thông số cài đặt dao của Nguyên công (CamSheets)");

                entity.Property(e => e.OrganizationGuid).HasComment("Mã guid của đơn vị");

                entity.Property(e => e.Bomnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BOMNumber")
                    .HasComment("Mã BOM");

                entity.Property(e => e.ProductItemId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ProductItemID")
                    .HasComment("Mã thành phẩm. Tham chiếu từ bảng [Inventory].[Items] với tính chất là P-Thành phẩm. Tự động điền = [BOMCategories].ItemID khi chọn BOMNumber  ");

                entity.Property(e => e.PartItemId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PartItemID")
                    .HasComment("Mã bán thành phẩm. Tham chiếu từ bảng [Inventory].[Items] với tính chất là B-Bán thành phẩm. Khi Loại Type khác 'B' thì lưu giá trị = rỗng");

                entity.Property(e => e.LocationId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("LocationID")
                    .HasComment("Mã quy trình công nghệ. Tham chiếu bảng Common.Locations.");

                entity.Property(e => e.CamSheetId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("CamSheetID");

                entity.Property(e => e.KnifeId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("KnifeID")
                    .HasComment("Mã Dao");

                entity.Property(e => e.CamSheetGuid).HasComment("Mã guid tham chiếu bảng [Pro_Sale].[BOMCamSheets]");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Depth)
                    .HasColumnType("numeric(18, 2)")
                    .HasComment("Chiều sâu");

                entity.Property(e => e.Length)
                    .HasColumnType("numeric(18, 2)")
                    .HasComment("Chiều dài");

                entity.Property(e => e.MachineTime).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasComment("Ngày và thời gian bản ghi được cập nhật.");

                entity.Property(e => e.Phi)
                    .HasColumnType("numeric(18, 2)")
                    .HasComment("Đơn vị đo Phi(Ø)");

                entity.Property(e => e.RowGuid).HasComment("Mã guid tự sinh của bảng");

                entity.Property(e => e.SetupTime).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Speed)
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("Tốc độ");

                entity.Property(e => e.StepProcess)
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("Bước tiến");

                entity.Property(e => e.Width)
                    .HasColumnType("numeric(18, 2)")
                    .HasComment("Chiều rộng");

                entity.HasOne(d => d.SaleBomcamSheet)
                    .WithMany(p => p.SaleBomcamSheetSettings)
                    .HasForeignKey(d => new { d.OrganizationGuid, d.Bomnumber, d.ProductItemId, d.PartItemId, d.LocationId, d.CamSheetId })
                    .HasConstraintName("FK_BOMCamSheetSettings_BOMCamSheets");
            });

            modelBuilder.Entity<SaleBomcategory>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationGuid, e.Bomnumber })
                    .HasName("PK_BOMCategories");

                entity.ToTable("SaleBOMCategories", "Pro_Sale");

                entity.HasComment("Danh sách BOM");

                entity.Property(e => e.OrganizationGuid).HasComment("Mã guid của đơn vị");

                entity.Property(e => e.Bomnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BOMNumber")
                    .HasComment("Mã BOM");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(100)
                    .HasComment("Người duyệt");

                entity.Property(e => e.ApprovedDate)
                    .HasColumnType("datetime")
                    .HasComment("Ngày duyệt");

                entity.Property(e => e.ApprovedStatus)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasComment("Trạng thái duyệt phiếu: N - Chưa duyệt. Y - Đã duyệt. NY - Không duyệt");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasComment("Người tạo");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Ngày tạo");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID")
                    .HasComment("Mã nhân viên bóc tách. Tham chiếu bảng [ES_HR].[HR].[Employees]");

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(50)
                    .HasComment("Tên nhân viên bóc tách.");

                entity.Property(e => e.FieldTypeId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("FieldTypeID")
                    .HasComment("Mã lĩnh vực sx thành phẩm. Tham chiếu bảng [Common].[FieldTypes]");

                entity.Property(e => e.ItemId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ItemID")
                    .HasComment("Mã Thành phẩm sản xuất (Mã nội bộ). Tham chiếu bảng ES_AM.Inventory.Items");

                entity.Property(e => e.ItemParentId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ItemParentID")
                    .HasComment("Thuộc sản phẩm gốc, cụm nào.");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasComment("Người sửa cuối cùng");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ParentId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ParentID");

                entity.Property(e => e.RowGuid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.RunNumber)
                    .HasDefaultValueSql("((1))")
                    .HasComment("Thứ tự của phiên bản.");

                entity.Property(e => e.Status)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasComment("Trạng thái. 0 - Chưa đặt hàng (mới báo giá), = 1 - Đã đặt hàng.");

                entity.HasOne(d => d.SaleItemWaitingQuotation)
                    .WithMany(p => p.SaleBomcategories)
                    .HasForeignKey(d => new { d.OrganizationGuid, d.ItemId })
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_BOMCategories_ItemWaitingQuotations");
            });

            modelBuilder.Entity<SaleBomcategoryHistory>(entity =>
            {
                entity.HasKey(e => e.RowGuid)
                    .HasName("PK_BOMCategoryHistories");

                entity.ToTable("SaleBOMCategoryHistories", "Pro_Sale");

                entity.HasComment("Lịch sử thay đổi BOM, phiên bản");

                entity.Property(e => e.RowGuid)
                    .ValueGeneratedNever()
                    .HasComment("Mã guid tự sinh của bảng.");

                entity.Property(e => e.Bomnumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BOMNumber")
                    .HasComment("Mã BOM. Tham chiếu bảng Pro.BOMCategories");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasComment("Người tạo");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasComment("Ngày tạo");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasComment("Lý do thay đổi");

                entity.Property(e => e.OrganizationGuid).HasComment("Mã guid của đơn vị");

                entity.HasOne(d => d.SaleBomcategory)
                    .WithMany(p => p.SaleBomcategoryHistories)
                    .HasForeignKey(d => new { d.OrganizationGuid, d.Bomnumber })
                    .HasConstraintName("FK_BOMCategoryHistories_BOMCategories");
            });

            modelBuilder.Entity<SaleBomcostNormHistory>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationGuid, e.Bomnumber, e.ProductItemId, e.Date, e.CostType })
                    .HasName("PK_BOMCostNormLegders");

                entity.ToTable("SaleBOMCostNormHistories", "Pro_Sale");

                entity.HasComment("Lịch sử giá thành sản xuất định mức");

                entity.Property(e => e.OrganizationGuid).HasComment("Mã guid của đơn vị");

                entity.Property(e => e.Bomnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BOMNumber")
                    .HasComment("Mã BOM. Tham chiếu bảng Pro.BOMCategories");

                entity.Property(e => e.ProductItemId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ProductItemID")
                    .HasComment("Mã thành phẩm. Tham chiếu từ bảng [Inventory].[Items] với tính chất là P-Thành phẩm. Tự động điền = [BOMCategories].ItemID khi chọn BOMNumber  ");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasComment("Ngày phát sinh/ ngày nhập chi phí");

                entity.Property(e => e.CostType)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasComment("Loại chi phí.  \r\n= G Chi phí gia công ngoài, \r\n= C Chi phí sx chung,\r\n= T Chi phí tài chính, \r\n= A Chi phí thất thoát, \r\n= V Chi phí nguyên liệu - vật liệu, \r\n= N Chi phí nhân công, \r\n= M - Chi phí sử dụng máy thi công, \r\n= K - Chi phí khác, \r\n= B - Chi phí bao bì");

                entity.Property(e => e.Amount)
                    .HasColumnType("numeric(20, 0)")
                    .HasComment("Số tiền phát sinh");

                entity.Property(e => e.AmountSurplus)
                    .HasColumnType("numeric(20, 0)")
                    .HasComment("Lũy kế tiền phát sinh");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.RowGuid).HasComment("Mã guid tự sinh của bảng");

                entity.HasOne(d => d.SaleBomcategory)
                    .WithMany(p => p.SaleBomcostNormHistories)
                    .HasForeignKey(d => new { d.OrganizationGuid, d.Bomnumber })
                    .HasConstraintName("FK_BOMCostNormHistories_BOMCategories");
            });

            modelBuilder.Entity<SaleBommaterialNorm>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationGuid, e.Bomnumber, e.ProductItemId, e.PartItemId, e.MaterialItemId })
                    .HasName("PK_BOMMaterialNorms");

                entity.ToTable("SaleBOMMaterialNorms", "Pro_Sale");

                entity.HasComment("Định mức vật liệu, Bán thành phẩm");

                entity.Property(e => e.OrganizationGuid).HasComment("Mã guid của đơn vị");

                entity.Property(e => e.Bomnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BOMNumber")
                    .HasComment("Mã BOM. Tham chiếu bảng Pro.BOMCategories");

                entity.Property(e => e.ProductItemId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ProductItemID")
                    .HasComment("Mã thành phẩm. Tham chiếu từ bảng [Inventory].[Items] với tính chất là P-Thành phẩm. Tự động điền = [BOMCategories].ItemID khi chọn BOMNumber  ");

                entity.Property(e => e.PartItemId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PartItemID")
                    .HasComment("Mã bán thành phẩm. Tham chiếu từ bảng [Inventory].[Items] với tính chất là B-Bán thành phẩm. Khi Loại Type khác 'B' thì lưu giá trị = rỗng");

                entity.Property(e => e.MaterialItemId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MaterialItemID")
                    .HasComment("Mã vật tư, hàng hóa. Tham chiếu từ bảng [Inventory].[Items] với tính chất là V-Vật tư hàng hóa. Khi Loại Type khác 'V' thì lưu giá trị = rỗng");

                entity.Property(e => e.Amount)
                    .HasColumnType("numeric(20, 0)")
                    .HasComment("Thành tiền");

                entity.Property(e => e.ChangeItemId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ChangeItemID")
                    .HasComment("Thay thế NVL");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasComment("Mô tả đặc điểm.");

                entity.Property(e => e.IsActive).HasComment("Trạng thái. = 1 Sử dụng, = 0 Ngừng sử dụng.");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ParentGuid).HasComment("Mã guid tham chiếu của mã thành phần cấp cha. Tham chiếu trực tiếp bảng hiện tại.");

                entity.Property(e => e.PercentLoss)
                    .HasColumnType("numeric(18, 3)")
                    .HasComment("Phần trăm hao hụt");

                entity.Property(e => e.Quantity)
                    .HasColumnType("numeric(20, 2)")
                    .HasComment("Số lượng vật tư.");

                entity.Property(e => e.QuantityLoss)
                    .HasColumnType("numeric(18, 3)")
                    .HasComment("Số lượng hao hụt. = % Hao hụt * Số lượng");

                entity.Property(e => e.RowGuid).HasComment("Mã guid tự sinh của bảng");

                entity.Property(e => e.SaleBomworkpiecesGuid)
                    .HasColumnName("SaleBOMWorkpiecesGuid")
                    .HasComment("Mã RowGuid của bảng SaleBOMWorkpieces khi thêm NVL, Phổi để hiển thị dạng tree");

                entity.Property(e => e.Size)
                    .HasMaxLength(400)
                    .HasComment("Kích thước");

                entity.Property(e => e.SortOrder).HasComment("Thứ tự sắp xếp");

                entity.Property(e => e.Type)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Loại. = B Bán thành phẩm, = V Vật tư dùng chung, = P Phôi sản xuất");

                entity.Property(e => e.UnitId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("UnitID")
                    .HasComment("Mã đơn vị tính. Nếu Loại định mức = V - Vật tư dùng chung thì lưu ĐVT của mã vật tư MaterialItemID. Nếu loại định mức = B thì lưu ĐVT của mã bán thành phẩm SemiFinishedItemID. ");

                entity.Property(e => e.UnitName).HasMaxLength(50);

                entity.Property(e => e.UnitPrice)
                    .HasColumnType("numeric(20, 2)")
                    .HasComment("Đơn giá (Ước tính nếu ko có trong kho)");

                entity.HasOne(d => d.SaleBomcategory)
                    .WithMany(p => p.SaleBommaterialNorms)
                    .HasForeignKey(d => new { d.OrganizationGuid, d.Bomnumber })
                    .HasConstraintName("FK_BOMMaterialNorms_BOMCategories");
            });

            modelBuilder.Entity<SaleBomworkOrderRouting>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationGuid, e.Bomnumber, e.ProductItemId, e.PartItemId, e.LocationId })
                    .HasName("PK_BOMWorkOrderRoutings");

                entity.ToTable("SaleBOMWorkOrderRoutings", "Pro_Sale");

                entity.HasComment("Quy trình công nghệ sản xuất bán thành phẩm, thành phẩm");

                entity.Property(e => e.OrganizationGuid).HasComment("Mã guid của đơn vị");

                entity.Property(e => e.Bomnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BOMNumber")
                    .HasComment("Mã BOM. Tham chiếu bảng Pro.BOMCategories");

                entity.Property(e => e.ProductItemId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ProductItemID")
                    .HasComment("Mã thành phẩm. Tham chiếu từ bảng [Inventory].[Items] với tính chất là P-Thành phẩm. Tự động điền = [BOMCategories].ItemID khi chọn BOMNumber  ");

                entity.Property(e => e.PartItemId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PartItemID")
                    .HasComment("Mã bán thành phẩm. Tham chiếu từ bảng [Inventory].[Items] với tính chất là B-Bán thành phẩm. Khi Loại Type khác 'B' thì lưu giá trị = rỗng");

                entity.Property(e => e.LocationId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("LocationID")
                    .HasComment("Mã quy trình công nghệ. Tham chiếu bảng Common.Locations.");

                entity.Property(e => e.AuxiliaryMaterialCost)
                    .HasColumnType("numeric(20, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Chi phí vật liệu phụ");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CuttingCost)
                    .HasColumnType("numeric(20, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Chi phí dụng cụ cắt");

                entity.Property(e => e.CuttingToolId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("CuttingToolID")
                    .HasComment("Mã dụng cụ cắt");

                entity.Property(e => e.ElectricityCost)
                    .HasColumnType("numeric(20, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Chi phí điện");

                entity.Property(e => e.FactoryCost)
                    .HasColumnType("numeric(20, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Chi phí nhà xưởng");

                entity.Property(e => e.FixtureCost)
                    .HasColumnType("numeric(20, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Chi phí đồ gá");

                entity.Property(e => e.FixtureId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("FixtureID")
                    .HasComment("Mã đồ gá");

                entity.Property(e => e.GroupLocationId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("GroupLocationID")
                    .HasComment("Mã khu vực vị trí của quy trình công nghệ. Tham chiếu bảng Common.GroupLocations, được lưu tự động khi chọn quy trình công nghệ.");

                entity.Property(e => e.InsuranceCost)
                    .HasColumnType("numeric(20, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Chi phí bảo hiểm công ty đóng");

                entity.Property(e => e.LaborCost)
                    .HasColumnType("numeric(20, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Chi phí lương nhân công");

                entity.Property(e => e.MachineCost)
                    .HasColumnType("numeric(20, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Chi phí máy.");

                entity.Property(e => e.MachineId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("MachineID")
                    .HasComment("Mã máy sử dụng dự kiến.");

                entity.Property(e => e.MeasuringCost)
                    .HasColumnType("numeric(20, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Chi phí dụng cụ đo");

                entity.Property(e => e.MeasuringToolId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("MeasuringToolID")
                    .HasComment("Mã dụng cụ đo");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NumberTask).HasComment("Số nhân công dự kiến. Mặc định = 1 nếu ng dùng không nhập");

                entity.Property(e => e.ProductionTime)
                    .HasColumnType("numeric(18, 2)")
                    .HasComment("Thời gian sản xuất (đvt = Phút)");

                entity.Property(e => e.RowGuid).HasComment("Mã guid tự sinh của bảng");

                entity.Property(e => e.SetupTime)
                    .HasColumnType("numeric(18, 2)")
                    .HasComment("Thời gian cài đặt Setup (đvt = Phút)");

                entity.Property(e => e.SortOrder).HasComment("Thứ tự của quy trình trong quá trình sản xuất Thành phẩm, Bán thành phẩm");

                entity.Property(e => e.TotalCost)
                    .HasColumnType("numeric(38, 4)")
                    .HasComputedColumnSql("(((((((((isnull([LaborCost],(0))+isnull([InsuranceCost],(0)))+isnull([MachineCost],(0)))+isnull([ElectricityCost],(0)))+isnull([FactoryCost],(0)))+isnull([FixtureCost],(0)))+isnull([CuttingCost],(0)))+isnull([MeasuringCost],(0)))+isnull([AuxiliaryMaterialCost],(0)))*isnull([ProductionTime],(1)))", false)
                    .HasComment("Tổng chi phí");

                entity.Property(e => e.Type)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Loại. = P Quy trình công nghệ sản xuất thành phẩm, = B Quy trình công nghệ sản xuất bán thành phẩm");

                entity.HasOne(d => d.SaleBomcategory)
                    .WithMany(p => p.SaleBomworkOrderRoutings)
                    .HasForeignKey(d => new { d.OrganizationGuid, d.Bomnumber })
                    .HasConstraintName("FK_BOMWorkOrderRoutings_BOMCategories");
            });

            modelBuilder.Entity<SaleBomworkpiece>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationGuid, e.Bomnumber, e.ProductItemId, e.PartItemId, e.LocationId, e.MaterialItemId })
                    .HasName("PK_BOMWorkpieces");

                entity.ToTable("SaleBOMWorkpieces", "Pro_Sale");

                entity.HasComment("Định mức NVL - Phôi dùng cho quy trình sản xuất bán thành phẩm (chỉ áp dụng quy trình có phôi)");

                entity.Property(e => e.OrganizationGuid).HasComment("Mã guid của đơn vị");

                entity.Property(e => e.Bomnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BOMNumber")
                    .HasComment("Mã BOM. Tham chiếu bảng Pro.BOMCategories");

                entity.Property(e => e.ProductItemId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ProductItemID")
                    .HasComment("Mã thành phẩm. Tham chiếu từ bảng [Inventory].[Items] với tính chất là P-Thành phẩm. Tự động điền = [BOMCategories].ItemID khi chọn BOMNumber  ");

                entity.Property(e => e.PartItemId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PartItemID")
                    .HasComment("Mã bán thành phẩm. Tham chiếu từ bảng [Inventory].[Items] với tính chất là B-Bán thành phẩm. Khi Loại Type khác 'B' thì lưu giá trị = rỗng");

                entity.Property(e => e.LocationId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("LocationID")
                    .HasComment("Mã quy trình công nghệ. Tham chiếu bảng Common.Locations.");

                entity.Property(e => e.MaterialItemId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MaterialItemID")
                    .HasComment("NVL - Phôi. Tham chiếu từ bảng [Inventory].[Items] với tính chất là V-Vật tư hàng hóa. Khi Loại Type khác 'V' thì lưu giá trị = rỗng");

                entity.Property(e => e.Amount)
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("Thành tiền = Trọng lượng phôi * Đơn giá.");

                entity.Property(e => e.ApecificGravity)
                    .HasColumnType("numeric(18, 2)")
                    .HasComment("Trọng lượng riêng");

                entity.Property(e => e.ConvertRate)
                    .HasColumnType("numeric(18, 3)")
                    .HasComment("Tỷ lệ chuyển đổi sang đvt của kho");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.High)
                    .HasColumnType("numeric(18, 2)")
                    .HasComment("Vật tư dạng tấm, khối (Chiều cao)");

                entity.Property(e => e.IsEdit).HasComment("Trạng thái giá đã cập nhật tỏng kho chứ: 0 - Chưa. 1- Rồi");

                entity.Property(e => e.Length)
                    .HasColumnType("numeric(18, 2)")
                    .HasComment("Dài");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PercentUsed)
                    .HasColumnType("numeric(18, 3)")
                    .HasComment("% Sử dụng");

                entity.Property(e => e.RowGuid).HasComment("Mã guid tự sinh của bảng");

                entity.Property(e => e.Shape)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('TAM')")
                    .HasComment("Hình dạng phôi. = TAM - Tấm, = TRON - Tròn");

                entity.Property(e => e.SizeId)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("SizeID")
                    .HasComment("VT dạng tròn, đường ký bên ngoài");

                entity.Property(e => e.SizeOd)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("SizeOD")
                    .HasComment("VT dạng tròn, đường kính bên trong");

                entity.Property(e => e.UnitId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UnitID")
                    .HasComment("Đơn vị tính đề nghị");

                entity.Property(e => e.UnitName)
                    .HasMaxLength(50)
                    .HasComment("Tên đvt đề nghị");

                entity.Property(e => e.UnitPrice)
                    .HasColumnType("numeric(18, 2)")
                    .HasComment("Đơn giá (Tự nhập hoặc lấy từ kho NVL)");

                entity.Property(e => e.Weight)
                    .HasColumnType("numeric(38, 6)")
                    .HasComputedColumnSql("(case [Shape] when 'TAM' then round(((([High]*[Wide])*[Length])*[ApecificGravity])/(1000000),(2)) else round(((((([High]*[High])*(3.14))*(0.25))*[ApecificGravity])*[Length])/(1000000),(2)) end)", false)
                    .HasComment("Trọng lượng phôi \r\n(KG)");

                entity.Property(e => e.Wide)
                    .HasColumnType("numeric(18, 2)")
                    .HasComment("Vật tư dạng tấm, khối (Chiều rộng)");

                entity.HasOne(d => d.SaleBomcategory)
                    .WithMany(p => p.SaleBomworkpieces)
                    .HasForeignKey(d => new { d.OrganizationGuid, d.Bomnumber })
                    .HasConstraintName("FK_BOMWorkpieces_BOMCategories");
            });

            modelBuilder.Entity<SaleItemWaitingQuotation>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationGuid, e.ItemId })
                    .HasName("PK_ItemWaitingQuotations");

                entity.ToTable("SaleItemWaitingQuotations", "Pro_Sale");

                entity.HasComment("Danh sách sản phẩm chờ bóc tách để báo giá.");

                entity.Property(e => e.OrganizationGuid).HasComment("Mã guid của đơn vị");

                entity.Property(e => e.ItemId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ItemID")
                    .HasComment("Mã sản phẩm, chi tiết");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CustomerID")
                    .HasComment("Mã khách hàng.");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(250)
                    .HasComment("Tên khách hàng");

                entity.Property(e => e.Description)
                    .HasMaxLength(400)
                    .HasComment("Đặc điểm kỹ thuật");

                entity.Property(e => e.High).HasMaxLength(250);

                entity.Property(e => e.ItemIdso)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ItemIDSO")
                    .HasComment("Mã sản phẩm khách hàng (nếu có)");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(400)
                    .HasComment("Tên sản phẩm.");

                entity.Property(e => e.Lenght)
                    .HasMaxLength(250)
                    .HasComment("Dài (mm)");

                entity.Property(e => e.Package)
                    .HasMaxLength(250)
                    .HasComment("Slg/Kiện (ea)");

                entity.Property(e => e.ParentId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ParentID")
                    .HasComment("Thuộc sản phẩm gốc nào. Chỉ áp dụng cho những sản phẩm có loại là Sản phẩm chi tiết. Tham chiếu trực tiếp bảng này.");

                entity.Property(e => e.Priority)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasComment("Mức ưu tiên. = CAO - Cao, = TB - Trung bình, = THAP - Thấp");

                entity.Property(e => e.Quantity)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("Số lượng bộ chi tiết");

                entity.Property(e => e.RowGuid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Size)
                    .HasMaxLength(250)
                    .HasComment("Kích thước");

                entity.Property(e => e.Solution)
                    .HasMaxLength(50)
                    .HasComment("Phương pháp");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasComment("Ngày lập sản phẩm");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Trạng thái");

                entity.Property(e => e.Transport)
                    .HasMaxLength(250)
                    .HasComment("Vận chuyển");

                entity.Property(e => e.Type)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Loại sản phẩm. T - Sản phẩm gốc, tổng, cụm. C - Sản phẩm chi tiết.");

                entity.Property(e => e.UnitId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UnitID")
                    .HasComment("Mã đvt");

                entity.Property(e => e.UnitName)
                    .HasMaxLength(50)
                    .HasComment("Têm đơn vị tính");

                entity.Property(e => e.Volumn)
                    .HasMaxLength(250)
                    .HasComment("Thể tích (m3)");

                entity.Property(e => e.Weight)
                    .HasMaxLength(250)
                    .HasComment("Cân nặng (kg)");

                entity.Property(e => e.Wide)
                    .HasMaxLength(250)
                    .HasComment("Rộng (mm)");
            });

            modelBuilder.Entity<SaleProductCostNorm>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationGuid, e.Bomnumber, e.ProductItemId, e.PartItemId, e.CostId, e.Type });

                entity.ToTable("SaleProductCostNorms", "Pro_Sale");

                entity.HasComment("Định mức chi phí Gia công ngoài, Chi phí chung, Chi phí tài chính, Chi phí thất thoát, Chi phí khác của Thành phẩm, Bán thành phẩm.");

                entity.Property(e => e.OrganizationGuid).HasComment("Mã guid của đơn vị");

                entity.Property(e => e.Bomnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BOMNumber")
                    .HasComment("Mã BOM");

                entity.Property(e => e.ProductItemId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ProductItemID")
                    .HasComment("Mã thành phẩm. Tham chiếu từ bảng [Inventory].[Items] với tính chất là P-Thành phẩm. Tự động điền = [BOMCategories].ItemID khi chọn BOMNumber  ");

                entity.Property(e => e.PartItemId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PartItemID")
                    .HasComment("Mã bán thành phẩm (nếu có). Tham chiếu từ bảng [Inventory].[Items] với tính chất là B-Bán thành phẩm. Nếu chi phí không tính theo bán thành phẩm thì lưu PartIemID = rỗng");

                entity.Property(e => e.CostId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("CostID")
                    .HasComment("Mã chi phí. Tham chiếu bảng Common.CostNorms với điều kiện Tính chất = C - Mã chi tiết. Được lọc theo Loại chi phí.");

                entity.Property(e => e.Type)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Loại chi phí. \r\n= N là Chi phí nhân công, \r\n= M là Chi phí Máy, \r\n= G là Chi phí gia công ngoài, \r\n= C là Chi phí chung, \r\n= D là Chi phí CCDC\r\n= T là Chi phí Tài chính, Lãi vay\r\n= K là Chi phí khác\r\n= A là Chi phí Thất thoát\r\n= B là Chi phí Bao bì");

                entity.Property(e => e.Amount)
                    .HasColumnType("numeric(20, 0)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Giá trị định mức. Mặc định = Quantity * CostPrice. Người dùng có thể tự nhập");

                entity.Property(e => e.CostName)
                    .HasMaxLength(400)
                    .HasComment("Tên chi phí");

                entity.Property(e => e.CostPrice)
                    .HasColumnType("numeric(20, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Đơn giá định mức. Tự động lấy theo Đơn giá của bảng định mức CostNorms theo Mã chi phí. Người dùng có thể sửa lại giá trị khác.");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasComment("Người tạo");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(400)
                    .HasComment("Ghi chú (nếu có)");

                entity.Property(e => e.InsuranceCostPrice)
                    .HasColumnType("numeric(20, 2)")
                    .HasComment("Chi phí bảo hiểm công ty đóng (tính theo đvt là phút). Chỉ áp dụng đối với loại chi phí = Nhân công");

                entity.Property(e => e.IsBoldFont).HasComment("= 1 Kiểu chữ in đậm, = 0 Chữ không in đậm");

                entity.Property(e => e.IsItalicFont).HasComment("= 1 Kiểu chữ in nghiêng, = 0 Chữ không in nghiêng");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasComment("Người sửa");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Quantity)
                    .HasColumnType("numeric(18, 2)")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Số lượng định mức (nếu có). Nếu không có thì gán = 1");

                entity.Property(e => e.RowGuid)
                    .HasDefaultValueSql("(newid())")
                    .HasComment("Mã Guid tự sinh của bảng");

                entity.Property(e => e.SortOrder).HasComment("Thứ tự sắp xếp");

                entity.Property(e => e.UnitId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UnitID")
                    .HasComment("Mã đvt. Tham chiếu bảng [ES_AM].[Common].[Units]");

                entity.Property(e => e.UnitName)
                    .HasMaxLength(50)
                    .HasComment("Tên đơn vị tính");

                entity.HasOne(d => d.SaleBomcategory)
                    .WithMany(p => p.SaleProductCostNorms)
                    .HasForeignKey(d => new { d.OrganizationGuid, d.Bomnumber })
                    .HasConstraintName("FK_SaleProductCostNorms_SaleBOMCategories");
            });

            modelBuilder.Entity<ScrapReason>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationGuid, e.ScrapReasonId });

                entity.ToTable("ScrapReasons", "Common");

                entity.HasComment("Nguyên nhân, lý do lỗi sx bán thành phẩm, thành phẩm. ");

                entity.Property(e => e.OrganizationGuid).HasComment("Mã guid của đơn vị");

                entity.Property(e => e.ScrapReasonId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ScrapReasonID")
                    .HasComment("Mã lý do, nguyên nhân lỗi");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasComment("Người tạo");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDefaultValue)
                    .HasDefaultValueSql("((0))")
                    .HasComment(" = 1 Là giá trị mặc định (sử dụng trên giao diện của các chức năng tham chiếu đến bảng này). = 0 Không là giá trị mặc định.");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasComment("Người sửa");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ScrapReasonGuid)
                    .HasDefaultValueSql("(newid())")
                    .HasComment("Mã guid tự sinh của bảng");

                entity.Property(e => e.SortOrder).HasComment("Thứ tự sắp xếp");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasComment("Mô tả lỗi");

                entity.Property(e => e.Type)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComment("Phân biệt lịa lỗi: L - Loại lỗi. N - Nguyên nhân lỗi, K - Lý do không đạt kế hoạch sx");
            });

            modelBuilder.Entity<StateProvince>(entity =>
            {
                entity.ToTable("StateProvince", "Person");

                entity.HasComment("Bảng danh mục  Quốc gia, tỉnh");

                entity.HasIndex(e => e.Name, "AK_StateProvince_Name")
                    .IsUnique();

                entity.HasIndex(e => new { e.StateProvinceCode, e.CountryRegionCode }, "AK_StateProvince_StateProvinceCode_CountryRegionCode")
                    .IsUnique();

                entity.HasIndex(e => e.Rowguid, "AK_StateProvince_rowguid")
                    .IsUnique();

                entity.Property(e => e.StateProvinceId)
                    .HasColumnName("StateProvinceID")
                    .HasComment("Khóa chính cho các bản ghi bảng StateProvince.");

                entity.Property(e => e.CountryRegionCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasComment("Mã quốc gia hoặc khu vực ( region) theo mã chuẩn quốc tế (ISO). Khóa ngoài cho bảng CountryRegion.CountryRegionCode. ");

                entity.Property(e => e.IsOnlyStateProvinceFlag)
                    .IsRequired()
                    .HasDefaultValueSql("((1))")
                    .HasComment("0 = StateProvinceCode tồn tại. 1 = StateProvinceCode không có sẵn, sử dụng CountryRegionCode.");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Ngày và thời gian bản ghi cập nhật lần cuối.");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("Mô tả tiểu bang hoặc tỉnh.");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newid())")
                    .HasComment("Định danh duy nhất của bản ghi. Được sử dụng hỗ trợ cho việc gộp, đồng bộ.");

                entity.Property(e => e.StateProvinceCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength(true)
                    .HasComment("Mã bang hoặc tỉnh theo chuẩn quốc tế (ISO)");

                entity.Property(e => e.TerritoryId)
                    .HasColumnName("TerritoryID")
                    .HasComment("ID của lãnh thổ mà tiểu bang, tỉnh trực thuộc. Khóa ngoài cho SalesTerritory.SalesTerritoryID.");
            });

            modelBuilder.Entity<Table1hatest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Table_1HATEST");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CustomerCode)
                    .HasMaxLength(50)
                    .HasComment("Mã khách hàng");

                entity.Property(e => e.CustomerName).HasMaxLength(500);

                entity.Property(e => e.Guikhuon)
                    .HasMaxLength(250)
                    .HasColumnName("guikhuon");

                entity.Property(e => e.ItemGuid).HasMaxLength(255);

                entity.Property(e => e.ItemId).HasMaxLength(500);

                entity.Property(e => e.ItemName)
                    .HasMaxLength(250)
                    .HasComment("Guid bán thành phẩm dùng cho loại khuôn");

                entity.Property(e => e.MachineId).HasMaxLength(500);

                entity.Property(e => e.MachineTypeId).HasMaxLength(500);

                entity.Property(e => e.Nhomkhuon)
                    .HasMaxLength(250)
                    .HasColumnName("nhomkhuon");

                entity.Property(e => e.OrganizationGuid).HasMaxLength(500);

                entity.Property(e => e.ProductSide).HasMaxLength(500);

                entity.Property(e => e.Size).HasMaxLength(500);

                entity.Property(e => e.StandardShotNumber).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.Status).HasMaxLength(500);

                entity.Property(e => e.TimeStandard).HasMaxLength(500);

                entity.Property(e => e.Title).HasMaxLength(500);
            });

            modelBuilder.Entity<TempPatron>(entity =>
            {
                entity.ToTable("TEMP_PATRON");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ChiPhi).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Dvt)
                    .HasMaxLength(50)
                    .HasColumnName("DVT");

                entity.Property(e => e.GhiChu).HasMaxLength(255);

                entity.Property(e => e.MaPa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MaPA");

                entity.Property(e => e.MaVt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MaVT");

                entity.Property(e => e.NhomVt)
                    .HasMaxLength(255)
                    .HasColumnName("NhomVT");

                entity.Property(e => e.TenPa)
                    .HasMaxLength(225)
                    .HasColumnName("TenPA");

                entity.Property(e => e.TenVt)
                    .HasMaxLength(255)
                    .HasColumnName("TenVT");

                entity.Property(e => e.TiLeHong).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TiLeTron).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<TypeOfProduction>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationGuid, e.FieldTypeId, e.TypeId });

                entity.ToTable("TypeOfProduction", "Common");

                entity.HasComment("Loại sản xuất. Là danh mục dùng cho phân loại sản phẩm trước khi sản xuất.");

                entity.Property(e => e.OrganizationGuid).HasComment("Mã guid của đơn vị");

                entity.Property(e => e.FieldTypeId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("FieldTypeID")
                    .HasComment("Mã lĩnh vực sản xuất. Tham chiếu bảng [Common].[FieldTypes]");

                entity.Property(e => e.TypeId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("TypeID")
                    .HasComment("Mã Loại sản xuất");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(400)
                    .HasComment("Mô tả");

                entity.Property(e => e.IsActive).HasComment("Trạng thái. = 0 Không sử dụng, = 1 Sử dụng");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RowGuid)
                    .HasDefaultValueSql("(newid())")
                    .HasComment("Mã tự sinh của bảng");

                entity.Property(e => e.Title)
                    .HasMaxLength(400)
                    .HasComment("Tên loại sản xuất");
            });

            modelBuilder.Entity<VAdditionalContactInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vAdditionalContactInfo", "Person");

                entity.HasComment("Displays the contact name and content from each element in the xml column AdditionalContactInfo for that person.");

                entity.Property(e => e.BusinessEntityId).HasColumnName("BusinessEntityID");

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CountryRegion).HasMaxLength(50);

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(128)
                    .HasColumnName("EMailAddress");

                entity.Property(e => e.EmailSpecialInstructions).HasColumnName("EMailSpecialInstructions");

                entity.Property(e => e.EmailTelephoneNumber)
                    .HasMaxLength(50)
                    .HasColumnName("EMailTelephoneNumber");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MiddleName).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PostalCode).HasMaxLength(50);

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");

                entity.Property(e => e.StateProvince).HasMaxLength(50);

                entity.Property(e => e.Street).HasMaxLength(50);

                entity.Property(e => e.TelephoneNumber).HasMaxLength(50);
            });

            modelBuilder.Entity<VEmployee>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vEmployee", "HumanResources");

                entity.HasComment("Employee names and addresses.");

                entity.Property(e => e.AdditionalContactInfo).HasColumnType("xml");

                entity.Property(e => e.AddressLine1)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.AddressLine2).HasMaxLength(60);

                entity.Property(e => e.BusinessEntityId).HasColumnName("BusinessEntityID");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.CountryRegionName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EmailAddress).HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.JobTitle)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MiddleName).HasMaxLength(50);

                entity.Property(e => e.PhoneNumber).HasMaxLength(25);

                entity.Property(e => e.PhoneNumberType).HasMaxLength(50);

                entity.Property(e => e.PostalCode)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.StateProvinceName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Suffix).HasMaxLength(10);

                entity.Property(e => e.Title).HasMaxLength(8);
            });

            modelBuilder.Entity<VEmployeeDepartment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vEmployeeDepartment", "HumanResources");

                entity.HasComment("Returns employee name, title, and current department.");

                entity.Property(e => e.BusinessEntityId).HasColumnName("BusinessEntityID");

                entity.Property(e => e.Department)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.JobTitle)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MiddleName).HasMaxLength(50);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.Suffix).HasMaxLength(10);

                entity.Property(e => e.Title).HasMaxLength(8);
            });

            modelBuilder.Entity<VEmployeeDepartmentHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vEmployeeDepartmentHistory", "HumanResources");

                entity.HasComment("Returns employee name and current and previous departments.");

                entity.Property(e => e.BusinessEntityId).HasColumnName("BusinessEntityID");

                entity.Property(e => e.Department)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MiddleName).HasMaxLength(50);

                entity.Property(e => e.Shift)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.Suffix).HasMaxLength(10);

                entity.Property(e => e.Title).HasMaxLength(8);
            });

            modelBuilder.Entity<VIndividualCustomer>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vIndividualCustomer", "Sales");

                entity.HasComment("Individual customers (names and addresses) that purchase Adventure Works Cycles products online.");

                entity.Property(e => e.AddressLine1)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.AddressLine2).HasMaxLength(60);

                entity.Property(e => e.AddressType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BusinessEntityId).HasColumnName("BusinessEntityID");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.CountryRegionName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Demographics).HasColumnType("xml");

                entity.Property(e => e.EmailAddress).HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MiddleName).HasMaxLength(50);

                entity.Property(e => e.PhoneNumber).HasMaxLength(25);

                entity.Property(e => e.PhoneNumberType).HasMaxLength(50);

                entity.Property(e => e.PostalCode)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.StateProvinceName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Suffix).HasMaxLength(10);

                entity.Property(e => e.Title).HasMaxLength(8);
            });

            modelBuilder.Entity<VJobCandidate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vJobCandidate", "HumanResources");

                entity.HasComment("Job candidate names and resumes.");

                entity.Property(e => e.AddrLocCity)
                    .HasMaxLength(100)
                    .HasColumnName("Addr.Loc.City");

                entity.Property(e => e.AddrLocCountryRegion)
                    .HasMaxLength(100)
                    .HasColumnName("Addr.Loc.CountryRegion");

                entity.Property(e => e.AddrLocState)
                    .HasMaxLength(100)
                    .HasColumnName("Addr.Loc.State");

                entity.Property(e => e.AddrPostalCode)
                    .HasMaxLength(20)
                    .HasColumnName("Addr.PostalCode");

                entity.Property(e => e.AddrType)
                    .HasMaxLength(30)
                    .HasColumnName("Addr.Type");

                entity.Property(e => e.BusinessEntityId).HasColumnName("BusinessEntityID");

                entity.Property(e => e.Email).HasColumnName("EMail");

                entity.Property(e => e.JobCandidateId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("JobCandidateID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NameFirst)
                    .HasMaxLength(30)
                    .HasColumnName("Name.First");

                entity.Property(e => e.NameLast)
                    .HasMaxLength(30)
                    .HasColumnName("Name.Last");

                entity.Property(e => e.NameMiddle)
                    .HasMaxLength(30)
                    .HasColumnName("Name.Middle");

                entity.Property(e => e.NamePrefix)
                    .HasMaxLength(30)
                    .HasColumnName("Name.Prefix");

                entity.Property(e => e.NameSuffix)
                    .HasMaxLength(30)
                    .HasColumnName("Name.Suffix");
            });

            modelBuilder.Entity<VJobCandidateEducation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vJobCandidateEducation", "HumanResources");

                entity.HasComment("Displays the content from each education related element in the xml column Resume in the HumanResources.JobCandidate table. The content has been localized into French, Simplified Chinese and Thai. Some data may not display correctly unless supplemental language support is installed.");

                entity.Property(e => e.EduDegree)
                    .HasMaxLength(50)
                    .HasColumnName("Edu.Degree");

                entity.Property(e => e.EduEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Edu.EndDate");

                entity.Property(e => e.EduGpa)
                    .HasMaxLength(5)
                    .HasColumnName("Edu.GPA");

                entity.Property(e => e.EduGpascale)
                    .HasMaxLength(5)
                    .HasColumnName("Edu.GPAScale");

                entity.Property(e => e.EduLevel).HasColumnName("Edu.Level");

                entity.Property(e => e.EduLocCity)
                    .HasMaxLength(100)
                    .HasColumnName("Edu.Loc.City");

                entity.Property(e => e.EduLocCountryRegion)
                    .HasMaxLength(100)
                    .HasColumnName("Edu.Loc.CountryRegion");

                entity.Property(e => e.EduLocState)
                    .HasMaxLength(100)
                    .HasColumnName("Edu.Loc.State");

                entity.Property(e => e.EduMajor)
                    .HasMaxLength(50)
                    .HasColumnName("Edu.Major");

                entity.Property(e => e.EduMinor)
                    .HasMaxLength(50)
                    .HasColumnName("Edu.Minor");

                entity.Property(e => e.EduSchool)
                    .HasMaxLength(100)
                    .HasColumnName("Edu.School");

                entity.Property(e => e.EduStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Edu.StartDate");

                entity.Property(e => e.JobCandidateId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("JobCandidateID");
            });

            modelBuilder.Entity<VJobCandidateEmployment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vJobCandidateEmployment", "HumanResources");

                entity.HasComment("Displays the content from each employement history related element in the xml column Resume in the HumanResources.JobCandidate table. The content has been localized into French, Simplified Chinese and Thai. Some data may not display correctly unless supplemental language support is installed.");

                entity.Property(e => e.EmpEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Emp.EndDate");

                entity.Property(e => e.EmpFunctionCategory).HasColumnName("Emp.FunctionCategory");

                entity.Property(e => e.EmpIndustryCategory).HasColumnName("Emp.IndustryCategory");

                entity.Property(e => e.EmpJobTitle)
                    .HasMaxLength(100)
                    .HasColumnName("Emp.JobTitle");

                entity.Property(e => e.EmpLocCity).HasColumnName("Emp.Loc.City");

                entity.Property(e => e.EmpLocCountryRegion).HasColumnName("Emp.Loc.CountryRegion");

                entity.Property(e => e.EmpLocState).HasColumnName("Emp.Loc.State");

                entity.Property(e => e.EmpOrgName)
                    .HasMaxLength(100)
                    .HasColumnName("Emp.OrgName");

                entity.Property(e => e.EmpResponsibility).HasColumnName("Emp.Responsibility");

                entity.Property(e => e.EmpStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Emp.StartDate");

                entity.Property(e => e.JobCandidateId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("JobCandidateID");
            });

            modelBuilder.Entity<VPersonDemographic>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPersonDemographics", "Sales");

                entity.HasComment("Displays the content from each element in the xml column Demographics for each customer in the Person.Person table.");

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.BusinessEntityId).HasColumnName("BusinessEntityID");

                entity.Property(e => e.DateFirstPurchase).HasColumnType("datetime");

                entity.Property(e => e.Education).HasMaxLength(30);

                entity.Property(e => e.Gender).HasMaxLength(1);

                entity.Property(e => e.MaritalStatus).HasMaxLength(1);

                entity.Property(e => e.Occupation).HasMaxLength(30);

                entity.Property(e => e.TotalPurchaseYtd)
                    .HasColumnType("money")
                    .HasColumnName("TotalPurchaseYTD");

                entity.Property(e => e.YearlyIncome).HasMaxLength(30);
            });

            modelBuilder.Entity<VProductAndDescription>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vProductAndDescription", "Production");

                entity.HasComment("Product names and descriptions. Product descriptions are provided in multiple languages.");

                entity.Property(e => e.CultureId)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasColumnName("CultureID")
                    .IsFixedLength(true);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductModel)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VProductModelCatalogDescription>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vProductModelCatalogDescription", "Production");

                entity.HasComment("Displays the content from each element in the xml column CatalogDescription for each product in the Production.ProductModel table that has catalog data.");

                entity.Property(e => e.Color).HasMaxLength(256);

                entity.Property(e => e.Copyright).HasMaxLength(30);

                entity.Property(e => e.Crankset).HasMaxLength(256);

                entity.Property(e => e.MaintenanceDescription).HasMaxLength(256);

                entity.Property(e => e.Material).HasMaxLength(256);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NoOfYears).HasMaxLength(256);

                entity.Property(e => e.Pedal).HasMaxLength(256);

                entity.Property(e => e.PictureAngle).HasMaxLength(256);

                entity.Property(e => e.PictureSize).HasMaxLength(256);

                entity.Property(e => e.ProductLine).HasMaxLength(256);

                entity.Property(e => e.ProductModelId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ProductModelID");

                entity.Property(e => e.ProductPhotoId)
                    .HasMaxLength(256)
                    .HasColumnName("ProductPhotoID");

                entity.Property(e => e.ProductUrl)
                    .HasMaxLength(256)
                    .HasColumnName("ProductURL");

                entity.Property(e => e.RiderExperience).HasMaxLength(1024);

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");

                entity.Property(e => e.Saddle).HasMaxLength(256);

                entity.Property(e => e.Style).HasMaxLength(256);

                entity.Property(e => e.WarrantyDescription).HasMaxLength(256);

                entity.Property(e => e.WarrantyPeriod).HasMaxLength(256);

                entity.Property(e => e.Wheel).HasMaxLength(256);
            });

            modelBuilder.Entity<VProductModelInstruction>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vProductModelInstructions", "Production");

                entity.HasComment("Displays the content from each element in the xml column Instructions for each product in the Production.ProductModel table that has manufacturing instructions.");

                entity.Property(e => e.LaborHours).HasColumnType("decimal(9, 4)");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.MachineHours).HasColumnType("decimal(9, 4)");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProductModelId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ProductModelID");

                entity.Property(e => e.Rowguid).HasColumnName("rowguid");

                entity.Property(e => e.SetupHours).HasColumnType("decimal(9, 4)");

                entity.Property(e => e.Step).HasMaxLength(1024);
            });

            modelBuilder.Entity<VSalesPerson>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSalesPerson", "Sales");

                entity.HasComment("Sales representiatives (names and addresses) and their sales-related information.");

                entity.Property(e => e.AddressLine1)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.AddressLine2).HasMaxLength(60);

                entity.Property(e => e.BusinessEntityId).HasColumnName("BusinessEntityID");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.CountryRegionName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EmailAddress).HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.JobTitle)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MiddleName).HasMaxLength(50);

                entity.Property(e => e.PhoneNumber).HasMaxLength(25);

                entity.Property(e => e.PhoneNumberType).HasMaxLength(50);

                entity.Property(e => e.PostalCode)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.SalesLastYear).HasColumnType("money");

                entity.Property(e => e.SalesQuota).HasColumnType("money");

                entity.Property(e => e.SalesYtd)
                    .HasColumnType("money")
                    .HasColumnName("SalesYTD");

                entity.Property(e => e.StateProvinceName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Suffix).HasMaxLength(10);

                entity.Property(e => e.TerritoryGroup).HasMaxLength(50);

                entity.Property(e => e.TerritoryName).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(8);
            });

            modelBuilder.Entity<VSalesPersonSalesByFiscalYear>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSalesPersonSalesByFiscalYears", "Sales");

                entity.HasComment("Uses PIVOT to return aggregated sales information for each sales representative.");

                entity.Property(e => e.FullName).HasMaxLength(152);

                entity.Property(e => e.JobTitle)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SalesPersonId).HasColumnName("SalesPersonID");

                entity.Property(e => e.SalesTerritory)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e._2002)
                    .HasColumnType("money")
                    .HasColumnName("2002");

                entity.Property(e => e._2003)
                    .HasColumnType("money")
                    .HasColumnName("2003");

                entity.Property(e => e._2004)
                    .HasColumnType("money")
                    .HasColumnName("2004");
            });

            modelBuilder.Entity<VStateProvinceCountryRegion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vStateProvinceCountryRegion", "Person");

                entity.HasComment("Joins StateProvince table with CountryRegion table.");

                entity.Property(e => e.CountryRegionCode)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.CountryRegionName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StateProvinceCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsFixedLength(true);

                entity.Property(e => e.StateProvinceId).HasColumnName("StateProvinceID");

                entity.Property(e => e.StateProvinceName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TerritoryId).HasColumnName("TerritoryID");
            });

            modelBuilder.Entity<VStoreWithAddress>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vStoreWithAddresses", "Sales");

                entity.HasComment("Stores (including store addresses) that sell Adventure Works Cycles products to consumers.");

                entity.Property(e => e.AddressLine1)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.AddressLine2).HasMaxLength(60);

                entity.Property(e => e.AddressType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BusinessEntityId).HasColumnName("BusinessEntityID");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.CountryRegionName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PostalCode)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.StateProvinceName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VStoreWithContact>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vStoreWithContacts", "Sales");

                entity.HasComment("Stores (including store contacts) that sell Adventure Works Cycles products to consumers.");

                entity.Property(e => e.BusinessEntityId).HasColumnName("BusinessEntityID");

                entity.Property(e => e.ContactType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EmailAddress).HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MiddleName).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PhoneNumber).HasMaxLength(25);

                entity.Property(e => e.PhoneNumberType).HasMaxLength(50);

                entity.Property(e => e.Suffix).HasMaxLength(10);

                entity.Property(e => e.Title).HasMaxLength(8);
            });

            modelBuilder.Entity<VStoreWithDemographic>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vStoreWithDemographics", "Sales");

                entity.HasComment("Stores (including demographics) that sell Adventure Works Cycles products to consumers.");

                entity.Property(e => e.AnnualRevenue).HasColumnType("money");

                entity.Property(e => e.AnnualSales).HasColumnType("money");

                entity.Property(e => e.BankName).HasMaxLength(50);

                entity.Property(e => e.Brands).HasMaxLength(30);

                entity.Property(e => e.BusinessEntityId).HasColumnName("BusinessEntityID");

                entity.Property(e => e.BusinessType).HasMaxLength(5);

                entity.Property(e => e.Internet).HasMaxLength(30);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Specialty).HasMaxLength(50);
            });

            modelBuilder.Entity<VVendorWithAddress>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vVendorWithAddresses", "Purchasing");

                entity.HasComment("Vendor (company) names and addresses .");

                entity.Property(e => e.AddressLine1)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.AddressLine2).HasMaxLength(60);

                entity.Property(e => e.AddressType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BusinessEntityId).HasColumnName("BusinessEntityID");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.CountryRegionName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PostalCode)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.StateProvinceName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VVendorWithContact>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vVendorWithContacts", "Purchasing");

                entity.HasComment("Vendor (company) names  and the names of vendor employees to contact.");

                entity.Property(e => e.BusinessEntityId).HasColumnName("BusinessEntityID");

                entity.Property(e => e.ContactType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EmailAddress).HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MiddleName).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PhoneNumber).HasMaxLength(25);

                entity.Property(e => e.PhoneNumberType).HasMaxLength(50);

                entity.Property(e => e.Suffix).HasMaxLength(10);

                entity.Property(e => e.Title).HasMaxLength(8);
            });

            modelBuilder.Entity<Workpiece>(entity =>
            {
                entity.HasKey(e => new { e.OrganizationGuid, e.ItemId });

                entity.ToTable("Workpiece", "Common");

                entity.HasComment("Danh mục phôi");

                entity.Property(e => e.OrganizationGuid).HasComment("Mã guid của đơn vị");

                entity.Property(e => e.ItemId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ItemID");

                entity.Property(e => e.ApecificGravity)
                    .HasColumnType("numeric(18, 2)")
                    .HasComment("Trọng lượng riêng");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasComment("Người tạo");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("((0))")
                    .HasComment("Ngày tạo");

                entity.Property(e => e.ItemName).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasComment("Người sửa cuối cùng");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.UnitId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UnitID");

                entity.Property(e => e.UnitName).HasMaxLength(50);

                entity.Property(e => e.UnitPrice)
                    .HasColumnType("numeric(18, 2)")
                    .HasComment("Đơn giá");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
