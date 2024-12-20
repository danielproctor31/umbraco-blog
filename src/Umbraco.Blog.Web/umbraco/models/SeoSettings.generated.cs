//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v15.0.0+76ed170
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace Umbraco.Cms.Web.Common.PublishedModels
{
	// Mixin Content Type with alias "seoSettings"
	/// <summary>SEO Settings</summary>
	public partial interface ISeoSettings : IPublishedContent
	{
		/// <summary>SEO Description</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.0.0+76ed170")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string SeoDescription { get; }

		/// <summary>SEO Title</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.0.0+76ed170")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string SeoTitle { get; }
	}

	/// <summary>SEO Settings</summary>
	[PublishedModel("seoSettings")]
	public partial class SeoSettings : PublishedContentModel, ISeoSettings
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.0.0+76ed170")]
		public new const string ModelTypeAlias = "seoSettings";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.0.0+76ed170")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.0.0+76ed170")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedContentTypeCache contentTypeCache)
			=> PublishedModelUtility.GetModelContentType(contentTypeCache, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.0.0+76ed170")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedContentTypeCache contentTypeCache, Expression<Func<SeoSettings, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(contentTypeCache), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public SeoSettings(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// SEO Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.0.0+76ed170")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("seoDescription")]
		public virtual string SeoDescription => GetSeoDescription(this, _publishedValueFallback);

		/// <summary>Static getter for SEO Description</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.0.0+76ed170")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetSeoDescription(ISeoSettings that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "seoDescription");

		///<summary>
		/// SEO Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.0.0+76ed170")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("seoTitle")]
		public virtual string SeoTitle => GetSeoTitle(this, _publishedValueFallback);

		/// <summary>Static getter for SEO Title</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "15.0.0+76ed170")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetSeoTitle(ISeoSettings that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "seoTitle");
	}
}
