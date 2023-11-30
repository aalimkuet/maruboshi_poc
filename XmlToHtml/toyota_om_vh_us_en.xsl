<?xml version="1.0" encoding="UTF-8"?>

<xsl:stylesheet version="1.0"
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

	<xsl:template match="toyota_om_vh_us_en">
		<html>
			<head>
				<link type="text/css" rel="stylesheet" href="./style.css" />
				<script src="https://cdn.jsdelivr.net/npm/@simondmc/popup-js@1.4.2/popup.min.js"></script>
				<script type="text/javascript" src="./script.js"></script>		
			</head>
			<body>

			<div id="myElement">
				<button id="myButton">Click me</button>
			</div>

				<h1>
					<xsl:variable name="chapter" select="./book/chapter/section/@id" />
					<xsl:variable name="substring" select="substring($chapter, 3, 2)" />
					<xsl:value-of select="$substring"/>
					<span> - </span>
					<xsl:value-of select="book/chapter/title" />
				</h1>
				<table id="1" style="border: 1px solid black; width: 100%">
					<xsl:for-each select="//section">
						<tr>
							<td>
								<h2>
									<xsl:value-of select="title"/>
								</h2>
							</td>
						</tr>
						<tr>
							<table id="2" >
								<xsl:for-each select="./pl//subsection_maintenance">
									<div>
										<tbody>
											<tr>
												<td>
													<h3 style="padding: 10px; background: #888; color: white">
														<xsl:value-of select=".//titlegroup//title"/>
													</h3>
												</td>
											</tr>
											<tr>
												<td >
													<div style="padding: 10px; background: #ddd;">
														<xsl:value-of select="./overview//paratabletxt"/>
													</div>
													<xsl:for-each select=".//topic">
														<div style="margin-top: 5px; padding: 5px; background: #ddd; border-bottom: 3px solid black; border-left: 8px solid black;">
															<xsl:value-of select=".//title" />
														</div>
														<div >
															<ul>
																<xsl:for-each select="./om_body/list1[@type='bull']/list1_item">
																	<li>
																		<xsl:value-of select="./itemtxt" />
																	</li>
																	<xsl:value-of select="./itemtxt_sub" />
																</xsl:for-each>
															</ul>
														</div>
														<p  >
															<xsl:value-of select="./om_body/p"/>
														</p>
													</xsl:for-each>
													<ul style="list-style-type:square;">
														<xsl:for-each select=".//note/note_body/note_para">
															<li>
																<b>
																	<xsl:value-of select="title" />
																</b>
															</li>
															<ul>
																<xsl:for-each select="att_list1/att_list1_item">
																	<li>
																		<xsl:value-of select="itemtxt"/>
																	</li>
																</xsl:for-each>
															</ul>
															<p >
																<xsl:value-of select="p"/>
															</p>
														</xsl:for-each>
													</ul>
													<xsl:for-each select="./attention[@type]">
														<table style="border: 2px solid black;">
															<tr>
																<th style="border: 1px solid black; ">
																	<xsl:choose>
																		<xsl:when test="@type='warning'">
																			<div style="background: #87CEEB;">&#9888; WARNING </div>
																		</xsl:when>
																		<xsl:otherwise>
																			<div>&#9888; NOTICE </div>
																		</xsl:otherwise>
																	</xsl:choose>
																</th>
															</tr>
															<tr>
																<td>
																	<ul>
																		<xsl:for-each select=".//attention_para">
																			<li style="list-style-type:square;">
																				<b>
																					<xsl:value-of select="./title" />
																				</b>
																			</li>
																			<ul>
																				<xsl:for-each select="./att_list1/att_list1_item">
																					<li>
																						<xsl:value-of select="./itemtxt" />
																					</li>
																					<ul>
																						<xsl:for-each select="./att_list2/att_list2_item">
																							<li>
																								<xsl:value-of select="./itemtxt" />
																							</li>
																						</xsl:for-each>
																					</ul>
																				</xsl:for-each>
																			</ul>
																			<xsl:value-of select="./p" />
																		</xsl:for-each>
																	</ul>
																</td>
															</tr>
														</table>
													</xsl:for-each>
												</td>
											</tr>
										</tbody>
									</div>
								</xsl:for-each>
								<xsl:for-each select=".//subsection_maintenance">
									<tr>
										<td>
											<h3 style="padding: 10px; background: #888; color: white">
												<xsl:value-of select=".//titlegroup//title"/>
											</h3>
										</td>
									</tr>
									<tr>
										<td>
											<div style="padding: 10px; background: #ddd;">
												<xsl:value-of select="./overview//paratabletxt"/>
											</div>
											<xsl:for-each select=".//topic">
												<div style="margin-top: 5px; padding: 5px; background: #ddd; border-bottom: 3px solid black; border-left: 8px solid black;">
													<xsl:value-of select=".//title" />
												</div>
												<div>
													<ul>
														<xsl:for-each select="./om_body/list1[@type='bull']/list1_item">
															<li>
																<xsl:value-of select="./itemtxt" />
															</li>
															<xsl:value-of select="./itemtxt_sub" />
														</xsl:for-each>
													</ul>
												</div>
												<p>
													<xsl:value-of select="./om_body/p"/>
												</p>
											</xsl:for-each>
											<ul style="list-style-type:square;">
												<xsl:for-each select=".//note/note_body/note_para">
													<li>
														<b>
															<xsl:value-of select="title" />
														</b>
													</li>
													<ul>
														<xsl:for-each select="att_list1/att_list1_item">
															<li>
																<xsl:value-of select="itemtxt"/>
															</li>
														</xsl:for-each>
													</ul>
													<p>
														<xsl:value-of select="p"/>
													</p>
												</xsl:for-each>
											</ul>
											<xsl:for-each select="./attention[@type]">
												<table style="border: 2px solid black;">
													<tr>
														<th style="border: 1px solid black;">
															<xsl:choose>
																<xsl:when test="@type='warning'">
																	<div style="background: #87CEEB;">&#9888; WARNING </div>
																</xsl:when>
																<xsl:otherwise>
																	<div>&#9888; NOTICE </div>
																</xsl:otherwise>
															</xsl:choose>
														</th>
													</tr>
													<tr>
														<td>
															<ul>
																<xsl:for-each select=".//attention_para">
																	<li style="list-style-type:square;">
																		<b>
																			<xsl:value-of select="./title" />
																		</b>
																	</li>
																	<ul>
																		<xsl:for-each select="./att_list1/att_list1_item">
																			<li>
																				<xsl:value-of select="./itemtxt" />
																			</li>
																			<ul>
																				<xsl:for-each select="./att_list2/att_list2_item">
																					<li>
																						<xsl:value-of select="./itemtxt" />
																					</li>
																				</xsl:for-each>
																			</ul>
																		</xsl:for-each>
																	</ul>
																	<xsl:value-of select="./p" />
																</xsl:for-each>
															</ul>
														</td>
													</tr>
												</table>
											</xsl:for-each>
										</td>
									</tr>
								</xsl:for-each>
							</table>
						</tr>
					</xsl:for-each>
				</table>
			</body>
		</html>
	</xsl:template>

</xsl:stylesheet>