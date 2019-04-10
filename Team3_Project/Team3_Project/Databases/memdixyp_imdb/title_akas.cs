namespace Team3_Project.Databases.memdixyp_imdb {
	public class title_akas : database {
		private static readonly System.Converter<database , title_akas> converter;
		public static readonly title_akas self;
		static title_akas() {
			converter = (database item) => (title_akas) item;
			self = new title_akas();
		}
		public static title_akas[] collection(subroutine subroutine , System.Object[] initialize) {
			return collection((superclass item) => (title_akas) item , () => new title_akas() , subroutine , initialize);
		}
		public static title_akas individual(subroutine subroutine , System.Object[] initialize) {
			return individual((superclass item) => (title_akas) item , () => new title_akas() , subroutine , initialize);
		}
		public type.String titleId;
		public type.Byte ordering;
		public type.String title;
		public type.String region;
		public type.String language;
		public type.String types;
		public type.String attributes;
		public type.Boolean isOriginalTitle;
		private title_akas() : base("memdixyp_imdb" , "title_akas") {
			this.titleId = new type.String("titleId");
			this.ordering = new type.Byte("ordering");
			this.title = new type.String("title");
			this.region = new type.String("region");
			this.language = new type.String("language");
			this.types = new type.String("types");
			this.attributes = new type.String("attributes");
			this.isOriginalTitle = new type.Boolean("isOriginalTitle");
		}
		protected override System.String[] columns() {
			return new System.String[] {
				nameof(this.titleId),
				nameof(this.ordering),
				nameof(this.title),
				nameof(this.region),
				nameof(this.language),
				nameof(this.types),
				nameof(this.attributes),
				nameof(this.isOriginalTitle)
			};
		}
		protected override type.abstraction[] values() {
			return new type.abstraction[] {
				this.titleId,
				this.ordering,
				this.title,
				this.region,
				this.language,
				this.types,
				this.attributes,
				this.isOriginalTitle
			};
		}
	}
}