# SitemapXMLParser

How to read a websites Sitemap.XML with C# and parse it's contents.

An XML Sitemap is a specially structured XML file which provides important structural information of a website to search engine crawlers for indexing purposes. The basic sitemap structure looks like this.

```
<urlset xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns="http://www.sitemaps.org/schemas/sitemap/0.9" xsi:schemalocation="http://www.sitemaps.org/schemas/sitemap/0.9 http://www.sitemaps.org/schemas/sitemap/0.9/sitemap.xsd">

<url>
<loc>https://lonewolfonline.net/</loc>
<priority>1.0</priority>
<lastmod>2010-09-14</lastmod>
<changefreq>daily</changefreq>
</url>

<url>
<loc>https://lonewolfonline.net/simple-xml-parser/</loc>
<priority>0.5</priority>
<lastmod>2009-09-14</lastmod>
<changefreq>monthly</changefreq>
</url>

</urlset>
```

Individual <code><url></code> tags are wrapped inside the containing <code><urlset></code> nodes.  Each <code><url></code> represents a page on the site. Inside the <code><url></code> node, are four nodes.

The <code><loc></code> node represents the page url.

The <code><priority></code> node represents the webmaster defined site map priority.

The <code><lastmod></code> node represents the date which the page was last modified..

The <code><changefreq></code> node indicates how often the page is updated and makes a suggestion to the search engine how often to crawl it again.

## Writing a Simple XML Parser in C#

For this example I am creating a small console application and outputting the resutls to the screen. I am also reading the sitemap from a file, but you can just as easily download files from a website instead.

Full tutorial - https://lonewolfonline.net/simple-xml-parser/
