# KuranadoSpider

此爬虫可用于[Wallpaper Abyss][link1]网站搜索结果的图片爬取,例如[CLANNAD壁纸][link2],以及图片链接的批量下载.


###     **使用方法**  

* 如果希望爬取指定搜索结果页面,例如[CLANNAD壁纸](link2),请按以下步骤操作:  
    * 用浏览器中打开[Wallpaper Abyss][link1],然后在输入框中搜索你感兴趣的图片,如`CLANNAD`,复制浏览器地址栏链接  
    * 将复制的链接粘贴到程序`下载`标签页的第一个富文本框内,若有多个链接请每个一行.  
    * 打开程序`设置`标签页,将`链接类型`选中为`待爬取网页`
    * 打开程序`下载`标签页, 点击`Start Download`按钮开始下载, 可以在`下载`标签页内查看相关输出信息
* 如果希望程序批量下载图片, 请按以下步骤操作:

    * 将希望批量下载的图片资源的链接输入富文本框,格式为每行一个链接
    * 打开程序`设置`标签页,将`链接类型`选中为`待下载图片`
    * 打开程序`下载`标签页, 点击`Start Download`按钮开始下载, 可以在`下载`标签页内查看相关输出信息

* **可选操作** 程序的`设置`标签页中各设置项如下:
    * `下载线程数` *:最多同时开启的下载线程数量, 如果将其设为0, 则在`待爬取网页`项选中时, 程序仅爬取链接, 而不下载图片, 而在`待下载图片`项选中时, 程序不会进行任何下载操作*
    * `失败重试次数` *:该功能暂未启用*
    * `每次下载最小耗时` *:该功能暂未启用*
    * `图片保存路径` *: 程序下载的图片将保存在此目录下,若目录不存在则会被创建*
    * `图片链接保存路径` *: 程序获取的图片下载链接将保存在此文件内, 程序将在每次开始爬取时删除并新建该文件*
    * `链接类型` *: 该项设定程序将以何种方式处理用户输入的链接*

[link1]:https://wall.alphacoders.com
[link2]:https://wall.alphacoders.com/search.php?lang=Chinese&search=CLANNAD


###     **许可证**
[MIT License](https://choosealicense.com/licenses/mit/#suggest-this-license)

Copyright (c) [year] [fullname]

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.