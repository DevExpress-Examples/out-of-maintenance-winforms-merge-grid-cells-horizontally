# How to merge cells horizontally in GridView


<p>Officially, GridControl doesn't support horizontal cell merging.  We recommend using <a href="https://documentation.devexpress.com/windowsforms/12063/controls-and-libraries/spreadsheet">Spreadsheet</a><u>,</u> which supports cell merging:<br><br><a href="https://documentation.devexpress.com/windowsforms/15416/controls-and-libraries/spreadsheet/examples/cells/how-to-merge-cells-or-split-merged-cells">How to: Merge Cells or Split Merged Cells</a> <br><br>If it's necessary for you to have this functionality in GridControl, you can use this example, which demonstrates how to merge cells located in the same row. <br>The main idea is to paint merged cell manually. You can find a helper class in this example, which can be easily connected to your existing GridView.</p>

<br/>


