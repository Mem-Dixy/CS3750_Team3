﻿namespace Team3_Project.Databases.memdixyp_film {
	public class list_follow : database {
		private static readonly System.Converter<database , list_follow> converter;
		public static readonly list_follow self;
		static list_follow() {
			converter = (database item) => (list_follow) item;
			self = new list_follow();
		}
		public static list_follow[] collection(subroutine subroutine , System.Object[] initialize) {
			return collection((superclass item) => (list_follow) item , () => new list_follow() , subroutine , initialize);
		}
		public static list_follow individual(subroutine subroutine , System.Object[] initialize) {
			return individual((superclass item) => (list_follow) item , () => new list_follow() , subroutine , initialize);
		}
		public type.Int32 user;
		public type.Int32 list;
		private list_follow() : base(nameof(memdixyp_film) , nameof(list_follow)) {
			this.user = new type.Int32();
			this.list = new type.Int32();
		}
		protected override System.String[] columns() {
			return new System.String[] {
				nameof(this.user),
				nameof(this.list)
			};
		}
		protected override type.abstraction[] values() {
			return new type.abstraction[] {
				this.user,
				this.list
			};
		}
	}
}