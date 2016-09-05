@Code
        Layout = "~/Views/Shared/_layout.vbhtml"
        ViewBag.Title = "Home"
End Code
<!DOCTYPE html>
<html>

<body id="content">

    <!-- / Top wrapper -->
    <!--
    #################################
        - THEMEPUNCH BANNER -
    #################################
    -->
    <div id="dajy" class="fullscreen-container mtslide sliderbg fixed">
        <div class="fullscreenbanner">
            <ul>

                <!-- papercut fade turnoff flyin slideright slideleft slideup slidedown-->
                <!-- FADE -->
                <li data-transition="fade" data-slotamount="1" data-masterspeed="300">
                    <img src="~/Content/HBThemes/images/slider/slide khach san 1.jpg" alt="" />
                    <div class="tp-caption scrolleffect sft"
                         data-x="center"
                         data-y="120"
                         data-speed="1000"
                         data-start="800"
                         data-easing="easeOutExpo">
                        <div class="sboxpurple textcenter">
                            <span class="lato size28 slim caps white">Hà Nội</span><br /><br /><br />
                            <span class="lato size100 slim caps white">Intercontinental</span><br />
                            <span class="lato size20 normal caps white">giá từ</span><br /><br />
                            <span class="lato size48 slim uppercase yellow">$2000</span><br />
                        </div>
                    </div>
                </li>

                <!-- FADE -->
                <li data-transition="fade" data-slotamount="1" data-masterspeed="300">
                    <img src="~/Content/HBThemes/images/slider/slide khach san 2.jpg" alt="" />
                    <div class="tp-caption scrolleffect sft"
                         data-x="center"
                         data-y="120"
                         data-speed="1000"
                         data-start="800"
                         data-easing="easeOutExpo">
                        <div class="sboxpurple textcenter">
                            <span class="lato size28 slim caps white">Nha Trang</span><br /><br /><br />
                            <span class="lato size100 slim caps white">Vinpearl Land</span><br />
                            <span class="lato size20 normal caps white">giá từ</span><br /><br />
                            <span class="lato size48 slim uppercase yellow">$1500</span><br />
                        </div>
                    </div>
                </li>

                <!-- FADE -->
                <li data-transition="fade" data-slotamount="1" data-masterspeed="300">

                    <img src="~/Content/HBThemes/images/slider/slide khach san 3.jpg" alt="" />
                    <div class="tp-caption scrolleffect sft"
                         data-x="center"
                         data-y="120"
                         data-speed="1000"
                         data-start="800"
                         data-easing="easeOutExpo">
                        <div class="sboxpurple textcenter">
                            <span class="lato size28 slim caps white">Quy Nhơn</span><br /><br /><br />
                            <span class="lato size100 slim caps white">FLC Luxury</span><br />
                            <span class="lato size20 normal caps white">giá từ</span><br /><br />
                            <span class="lato size48 slim uppercase yellow">$1000</span><br />
                        </div>
                    </div>
                </li>

            </ul>
            <div class="tp-bannertimer none"></div>
        </div>
    </div>

    <!--
    ##############################
     - ACTIVATE THE BANNER HERE -
    ##############################
    -->
    <script type="text/javascript">

        var tpj = jQuery;
        tpj.noConflict();

        tpj(document).ready(function () {

            if (tpj.fn.cssOriginal != undefined)
                tpj.fn.css = tpj.fn.cssOriginal;

            tpj('.fullscreenbanner').revolution(
                {
                    delay: 9000,
                    startwidth: 1170,
                    startheight: 600,

                    onHoverStop: "on",						// Stop Banner Timet at Hover on Slide on/off

                    thumbWidth: 100,							// Thumb With and Height and Amount (only if navigation Tyope set to thumb !)
                    thumbHeight: 50,
                    thumbAmount: 3,

                    hideThumbs: 0,
                    navigationType: "bullet",				// bullet, thumb, none
                    navigationArrows: "solo",				// nexttobullets, solo (old name verticalcentered), none

                    navigationStyle: false,				// round,square,navbar,round-old,square-old,navbar-old, or any from the list in the docu (choose between 50+ different item), custom


                    navigationHAlign: "left",				// Vertical Align top,center,bottom
                    navigationVAlign: "bottom",					// Horizontal Align left,center,right
                    navigationHOffset: 30,
                    navigationVOffset: 30,

                    soloArrowLeftHalign: "left",
                    soloArrowLeftValign: "center",
                    soloArrowLeftHOffset: 20,
                    soloArrowLeftVOffset: 0,

                    soloArrowRightHalign: "right",
                    soloArrowRightValign: "center",
                    soloArrowRightHOffset: 20,
                    soloArrowRightVOffset: 0,

                    touchenabled: "on",						// Enable Swipe Function : on/off


                    stopAtSlide: -1,							// Stop Timer if Slide "x" has been Reached. If stopAfterLoops set to 0, then it stops already in the first Loop at slide X which defined. -1 means do not stop at any slide. stopAfterLoops has no sinn in this case.
                    stopAfterLoops: -1,						// Stop Timer if All slides has been played "x" times. IT will stop at THe slide which is defined via stopAtSlide:x, if set to -1 slide never stop automatic

                    hideCaptionAtLimit: 0,					// It Defines if a caption should be shown under a Screen Resolution ( Basod on The Width of Browser)
                    hideAllCaptionAtLilmit: 0,				// Hide all The Captions if Width of Browser is less then this value
                    hideSliderAtLimit: 0,					// Hide the whole slider, and stop also functions if Width of Browser is less than this value


                    fullWidth: "on",							// Same time only Enable FullScreen of FullWidth !!
                    fullScreen: "off",						// Same time only Enable FullScreen of FullWidth !!


                    shadow: 0								//0 = no Shadow, 1,2,3 = 3 Different Art of Shadows -  (No Shadow in Fullwidth Version !)

                });


        });
    </script>






    <!-- WRAP -->
    <div class="wrap cstyle03">

        <div class="container mt-200 z-index100">
            <div class="row">
                <div class="col-md-4">
                    <div class="bs-example bs-example-tabs cstyle04">

                        <ul class="nav nav-tabs" id="myTab">
                            <li onclick="mySelectUpdate()" class="active"><a data-toggle="tab" href="#air"><span class="flight"></span>Chuyến bay</a></li>
                            <li onclick="mySelectUpdate()" class=""><a data-toggle="tab" href="#hotel"><span class="hotel"></span>Khách sạn</a></li>
                            <li onclick="mySelectUpdate()" class=""><a data-toggle="tab" href="#car"><span class="car"></span>Xe</a></li>
                            <li onclick="mySelectUpdate()" class=""><a data-toggle="tab" href="#vacations"><span class="suitcase"></span>Du lịch</a></li>
                        </ul>

                        <div class="tab-content3" id="myTabContent">

                            <div id="air" class="tab-pane fade active in">

                                <div class="w50percent">
                                    <div class="wh90percent textleft">
                                        <span class="opensans size13"><b>Điểm đi</b></span>
                                        <input type="text" class="form-control" placeholder="City or airport">
                                    </div>
                                </div>

                                <div class="w50percentlast">
                                    <div class="wh90percent textleft right">
                                        <span class="opensans size13"><b>Điểm đến</b></span>
                                        <input type="text" class="form-control" placeholder="City or airport">
                                    </div>
                                </div>


                                <div class="clearfix"></div><br />

                                <div class="w50percent">
                                    <div class="wh90percent textleft">
                                        <span class="opensans size13"><b>Ngày đi</b></span>
                                        <input type="text" class="form-control mySelectCalendar" id="datepicker3" placeholder="mm/dd/yyyy" />
                                    </div>
                                </div>

                                <div class="w50percentlast">
                                    <div class="wh90percent textleft right">
                                        <span class="opensans size13"><b>Ngày về</b></span>
                                        <input type="text" class="form-control mySelectCalendar" id="datepicker4" placeholder="mm/dd/yyyy" />
                                    </div>
                                </div>

                                <div class="clearfix"></div>

                                <div class="room1 margtop15">
                                    <div class="w50percent">
                                        <div class="wh90percent textleft">
                                            <span class="opensans size13"><b>Người lớn</b></span>
                                            <select class="form-control mySelectBoxClass">
                                                <option>1</option>
                                                <option selected>2</option>
                                                <option>3</option>
                                                <option>4</option>
                                                <option>5</option>
                                            </select>
                                        </div>
                                    </div>

                                    <div class="w50percentlast">
                                        <div class="wh90percent textleft right">
                                            <span class="opensans size13"><b>Trẻ em</b></span>
                                            <select class="form-control mySelectBoxClass">
                                                <option>0</option>
                                                <option selected>1</option>
                                                <option>2</option>
                                                <option>3</option>
                                                <option>4</option>
                                                <option>5</option>
                                            </select>
                                        </div>
                                    </div>
                                </div>

                            </div>
                            <!--End of 1st tab -->

                            <div id="hotel" class="tab-pane fade">

                                <span class="opensans size18">Bạn muốn đi đâu?</span>
                                <input type="text" class="form-control" placeholder="Hà Nội">

                                <br />

                                <div class="w50percent">
                                    <div class="wh90percent textleft">
                                        <span class="opensans size13"><b>Ngày nhận phòng</b></span>
                                        <input type="text" class="form-control mySelectCalendar" id="datepicker" placeholder="mm/dd/yyyy" />
                                    </div>
                                </div>

                                <div class="w50percentlast">
                                    <div class="wh90percent textleft right">
                                        <span class="opensans size13"><b>Ngày trả phòng</b></span>
                                        <input type="text" class="form-control mySelectCalendar" id="datepicker2" placeholder="mm/dd/yyyy" />
                                    </div>
                                </div>

                                <div class="clearfix"></div>

                                <div class="room1 margtop15">
                                    <div class="w50percent">
                                        <div class="wh90percent textleft">
                                            <span class="opensans size13"><b>ROOM 1</b></span><br />

                                            <div class="addroom1 block">
                                                <a href="#room2" onclick="addroom2()" class="grey">+ Add room</a>
                                            </div>
                                        </div>
                                    </div>

                                    <div class="w50percentlast">
                                        <div class="wh90percent textleft right ohidden">
                                            <div class="w50percent">
                                                <div class="wh90percent textleft left">
                                                    <span class="opensans size13"><b>Nglớn</b></span>
                                                    <select class="form-control mySelectBoxClass">
                                                        <option>1</option>
                                                        <option selected>2</option>
                                                        <option>3</option>
                                                        <option>4</option>
                                                        <option>5</option>
                                                    </select>
                                                </div>
                                            </div>
                                            <div class="w50percentlast">
                                                <div class="wh90percent textleft right ohidden">
                                                    <span class="opensans size13"><b>Trẻ em</b></span>
                                                    <select class="form-control mySelectBoxClass">
                                                        <option>0</option>
                                                        <option selected>1</option>
                                                        <option>2</option>
                                                        <option>3</option>
                                                        <option>4</option>
                                                        <option>5</option>
                                                    </select>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>

                                <div class="room2 none">
                                    <div class="clearfix"></div>
                                    <div class="line1"></div>
                                    <div class="w50percent">
                                        <div class="wh90percent textleft">
                                            <span class="opensans size13"><b>ROOM 2</b></span><br />
                                            <div class="addroom2 block grey">
                                                <a href="#" onclick="addroom3()" class="grey">+ Add room</a> | <a href="#" onclick="removeroom2()" class="orange"><img src="~/Content/HBThemes/images/delete.png" alt="delete" /></a>
                                            </div>
                                        </div>
                                    </div>

                                    <div class="w50percentlast">
                                        <div class="wh90percent textleft right">
                                            <div class="w50percent">
                                                <div class="wh90percent textleft left">
                                                    <span class="opensans size13"><b>Nglớn</b></span>
                                                    <select class="form-control mySelectBoxClass">
                                                        <option>1</option>
                                                        <option>2</option>
                                                        <option selected>3</option>
                                                        <option>4</option>
                                                        <option>5</option>
                                                    </select>
                                                </div>
                                            </div>
                                            <div class="w50percentlast">
                                                <div class="wh90percent textleft right">
                                                    <span class="opensans size13"><b>Trẻ em</b></span>
                                                    <select class="form-control mySelectBoxClass">
                                                        <option selected>0</option>
                                                        <option>1</option>
                                                        <option>2</option>
                                                        <option>3</option>
                                                        <option>4</option>
                                                        <option>5</option>
                                                    </select>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>

                                <div class="room3 none">
                                    <div class="clearfix"></div>
                                    <div class="line1"></div>
                                    <div class="w50percent">
                                        <div class="wh90percent textleft">
                                            <span class="opensans size13"><b>ROOM 3</b></span><br />
                                            <div class="addroom3 block grey">
                                                <a href="#" onclick="addroom3()" class="grey">+ Add room</a> | <a href="#" onclick="removeroom3()" class="orange"><img src="~/Content/HBThemes/images/delete.png" alt="delete" /></a>
                                            </div>
                                        </div>
                                    </div>

                                    <div class="w50percentlast">
                                        <div class="wh90percent textleft right">
                                            <div class="w50percent">
                                                <div class="wh90percent textleft left">
                                                    <span class="opensans size13"><b>Nglớn</b></span>
                                                    <select class="form-control mySelectBoxClass">
                                                        <option selected>1</option>
                                                        <option>2</option>
                                                        <option>3</option>
                                                        <option>4</option>
                                                        <option>5</option>
                                                    </select>
                                                </div>
                                            </div>
                                            <div class="w50percentlast">
                                                <div class="wh90percent textleft right">
                                                    <span class="opensans size13"><b>Trẻ em</b></span>
                                                    <select class="form-control mySelectBoxClass">
                                                        <option selected>0</option>
                                                        <option>1</option>
                                                        <option>2</option>
                                                        <option>3</option>
                                                        <option>4</option>
                                                        <option>5</option>
                                                    </select>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>

                            </div>

                            <!--End of 2nd tab -->
                            <div id="car" class="tab-pane fade">

                                <div class="w50percent">
                                    <div class="wh90percent textleft">
                                        <span class="opensans size13"><b>Nơi nhận</b></span>
                                        <input type="text" class="form-control" placeholder="Airport, address">
                                    </div>
                                </div>

                                <div class="w50percentlast">
                                    <div class="wh90percent textleft right">
                                        <span class="opensans size13"><b>Nơi trả</b></span>
                                        <input type="text" class="form-control" placeholder="Airport, address">
                                    </div>
                                </div>


                                <div class="clearfix"></div><br />

                                <div class="w50percent">
                                    <div class="wh90percent textleft">
                                        <span class="opensans size13"><b>Ngày nhận</b></span>
                                        <input type="text" class="form-control mySelectCalendar" id="datepicker5" placeholder="mm/dd/yyyy" />
                                    </div>
                                </div>

                                <div class="w50percentlast">
                                    <div class="wh90percent textleft right">
                                        <span class="opensans size13"><b>Giờ</b></span>
                                        <select class="form-control mySelectBoxClass">
                                            <option>12:00 AM</option>
                                            <option>12:30 AM</option>
                                            <option>01:00 AM</option>
                                            <option>01:30 AM</option>
                                            <option>02:00 AM</option>
                                            <option>02:30 AM</option>
                                            <option>03:00 AM</option>
                                            <option>03:30 AM</option>
                                            <option>04:00 AM</option>
                                            <option>04:30 AM</option>
                                            <option>05:00 AM</option>
                                            <option>05:30 AM</option>
                                            <option>06:00 AM</option>
                                            <option>06:30 AM</option>
                                            <option>07:00 AM</option>
                                            <option>07:30 AM</option>
                                            <option>08:00 AM</option>
                                            <option>08:30 AM</option>
                                            <option>09:00 AM</option>
                                            <option>09:30 AM</option>
                                            <option>10:00 AM</option>
                                            <option selected>10:30 AM</option>
                                            <option>11:00 AM</option>
                                            <option>11:30 AM</option>
                                            <option>12:00 PM</option>
                                            <option>12:30 PM</option>
                                            <option>01:00 PM</option>
                                            <option>01:30 PM</option>
                                            <option>02:00 PM</option>
                                            <option>02:30 PM</option>
                                            <option>03:00 PM</option>
                                            <option>03:30 PM</option>
                                            <option>04:00 PM</option>
                                            <option>04:30 PM</option>
                                            <option>05:00 PM</option>
                                            <option>05:30 PM</option>
                                            <option>06:00 PM</option>
                                            <option>06:30 PM</option>
                                            <option>07:00 PM</option>
                                            <option>07:30 PM</option>
                                            <option>08:00 PM</option>
                                            <option>08:30 PM</option>
                                            <option>09:00 PM</option>
                                            <option>09:30 PM</option>
                                            <option>10:00 PM</option>
                                            <option>10:30 PM</option>
                                            <option>11:00 PM</option>
                                            <option>11:30 PM</option>
                                        </select>
                                    </div>
                                </div>

                                <div class="clearfix"></div>

                                <div class="room1 margtop15">
                                    <div class="w50percent">
                                        <div class="wh90percent textleft">
                                            <span class="opensans size13"><b>Ngày trả</b></span>
                                            <input type="text" class="form-control mySelectCalendar" id="datepicker6" placeholder="mm/dd/yyyy" />
                                        </div>
                                    </div>

                                    <div class="w50percentlast">
                                        <div class="wh90percent textleft right">
                                            <span class="opensans size13"><b>Giờ</b></span>
                                            <select class="form-control mySelectBoxClass">
                                                <option>12:00 AM</option>
                                                <option>12:30 AM</option>
                                                <option>01:00 AM</option>
                                                <option>01:30 AM</option>
                                                <option>02:00 AM</option>
                                                <option>02:30 AM</option>
                                                <option>03:00 AM</option>
                                                <option>03:30 AM</option>
                                                <option>04:00 AM</option>
                                                <option>04:30 AM</option>
                                                <option>05:00 AM</option>
                                                <option>05:30 AM</option>
                                                <option>06:00 AM</option>
                                                <option>06:30 AM</option>
                                                <option>07:00 AM</option>
                                                <option>07:30 AM</option>
                                                <option>08:00 AM</option>
                                                <option>08:30 AM</option>
                                                <option>09:00 AM</option>
                                                <option>09:30 AM</option>
                                                <option>10:00 AM</option>
                                                <option selected>10:30 AM</option>
                                                <option>11:00 AM</option>
                                                <option>11:30 AM</option>
                                                <option>12:00 PM</option>
                                                <option>12:30 PM</option>
                                                <option>01:00 PM</option>
                                                <option>01:30 PM</option>
                                                <option>02:00 PM</option>
                                                <option>02:30 PM</option>
                                                <option>03:00 PM</option>
                                                <option>03:30 PM</option>
                                                <option>04:00 PM</option>
                                                <option>04:30 PM</option>
                                                <option>05:00 PM</option>
                                                <option>05:30 PM</option>
                                                <option>06:00 PM</option>
                                                <option>06:30 PM</option>
                                                <option>07:00 PM</option>
                                                <option>07:30 PM</option>
                                                <option>08:00 PM</option>
                                                <option>08:30 PM</option>
                                                <option>09:00 PM</option>
                                                <option>09:30 PM</option>
                                                <option>10:00 PM</option>
                                                <option>10:30 PM</option>
                                                <option>11:00 PM</option>
                                                <option>11:30 PM</option>
                                            </select>
                                        </div>
                                    </div>
                                </div>

                            </div>
                            <!--End of 3rd tab -->

                            <div id="vacations" class="tab-pane fade">

                                <div class="w50percent">
                                    <div class="wh90percent textleft">
                                        <span class="opensans size13"><b>Điểm đi</b></span>
                                        <input type="text" class="form-control" placeholder="City or airport">
                                    </div>
                                </div>

                                <div class="w50percentlast">
                                    <div class="wh90percent textleft right">
                                        <span class="opensans size13"><b>Điểm đến</b></span>
                                        <input type="text" class="form-control" placeholder="City or airport">
                                    </div>
                                </div>

                                <div class="clearfix"></div><br />

                                <div class="w50percent">
                                    <div class="wh90percent textleft">
                                        <span class="opensans size13"><b>Ngày đi</b></span>
                                        <input type="text" class="form-control mySelectCalendar" id="datepicker7" placeholder="mm/dd/yyyy" />
                                    </div>
                                </div>

                                <div class="w50percentlast">
                                    <div class="wh90percent textleft right">
                                        <span class="opensans size13"><b>Ngày về</b></span>
                                        <input type="text" class="form-control mySelectCalendar" id="datepicker8" placeholder="mm/dd/yyyy" />
                                    </div>
                                </div>

                                <div class="clearfix"></div>

                                <div class="room1 margtop15">
                                    <div class="w50percent">
                                        <div class="wh90percent textleft">
                                            <span class="opensans size13"><b>ROOM 1</b></span><br />

                                            <div class="addroom1 block">
                                                <a href="#room2" onclick="addroom2()" class="grey">+ Add room</a>
                                            </div>
                                        </div>
                                    </div>

                                    <div class="w50percentlast">
                                        <div class="wh90percent textleft right">
                                            <div class="w50percent">
                                                <div class="wh90percent textleft left">
                                                    <span class="opensans size13"><b>Nglớn</b></span>
                                                    <select class="form-control mySelectBoxClass">
                                                        <option>1</option>
                                                        <option selected>2</option>
                                                        <option>3</option>
                                                        <option>4</option>
                                                        <option>5</option>
                                                    </select>
                                                </div>
                                            </div>
                                            <div class="w50percentlast">
                                                <div class="wh90percent textleft right">
                                                    <span class="opensans size13"><b>Trẻ em</b></span>
                                                    <select class="form-control mySelectBoxClass">
                                                        <option>0</option>
                                                        <option selected>1</option>
                                                        <option>2</option>
                                                        <option>3</option>
                                                        <option>4</option>
                                                        <option>5</option>
                                                    </select>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>

                                <div class="room2 none">
                                    <div class="clearfix"></div>
                                    <div class="line1"></div>
                                    <div class="w50percent">
                                        <div class="wh90percent textleft">
                                            <span class="opensans size13"><b>ROOM 2</b></span><br />
                                            <div class="addroom2 block grey">
                                                <a href="#" onclick="addroom3()" class="grey">+ Add room</a> | <a href="#" onclick="removeroom2()" class="orange"><img src="~/Content/HBThemes/images/delete.png" alt="delete" /></a>
                                            </div>
                                        </div>
                                    </div>

                                    <div class="w50percentlast">
                                        <div class="wh90percent textleft right">
                                            <div class="w50percent">
                                                <div class="wh90percent textleft left">
                                                    <span class="opensans size13"><b>Nglớn</b></span>
                                                    <select class="form-control mySelectBoxClass">
                                                        <option>1</option>
                                                        <option>2</option>
                                                        <option selected>3</option>
                                                        <option>4</option>
                                                        <option>5</option>
                                                    </select>
                                                </div>
                                            </div>
                                            <div class="w50percentlast">
                                                <div class="wh90percent textleft right">
                                                    <span class="opensans size13"><b>Trẻ em</b></span>
                                                    <select class="form-control mySelectBoxClass">
                                                        <option selected>0</option>
                                                        <option>1</option>
                                                        <option>2</option>
                                                        <option>3</option>
                                                        <option>4</option>
                                                        <option>5</option>
                                                    </select>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>

                                <div class="room3 none">
                                    <div class="clearfix"></div>
                                    <div class="line1"></div>
                                    <div class="w50percent">
                                        <div class="wh90percent textleft">
                                            <span class="opensans size13"><b>ROOM 3</b></span><br />
                                            <div class="addroom3 block grey">
                                                <a href="#" onclick="addroom3()" class="grey">+ Add room</a> | <a href="#" onclick="removeroom3()" class="orange"><img src="~/Content/HBThemes/images/delete.png" alt="delete" /></a>
                                            </div>
                                        </div>
                                    </div>

                                    <div class="w50percentlast">
                                        <div class="wh90percent textleft right">
                                            <div class="w50percent">
                                                <div class="wh90percent textleft left">
                                                    <span class="opensans size13"><b>Nglớn</b></span>
                                                    <select class="form-control mySelectBoxClass">
                                                        <option selected>1</option>
                                                        <option>2</option>
                                                        <option>3</option>
                                                        <option>4</option>
                                                        <option>5</option>
                                                    </select>
                                                </div>
                                            </div>
                                            <div class="w50percentlast">
                                                <div class="wh90percent textleft right">
                                                    <span class="opensans size13"><b>Trẻ em</b></span>
                                                    <select class="form-control mySelectBoxClass">
                                                        <option selected>0</option>
                                                        <option>1</option>
                                                        <option>2</option>
                                                        <option>3</option>
                                                        <option>4</option>
                                                        <option>5</option>
                                                    </select>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>

                            </div>
                            <!--End of 4th tab -->
                        </div>

                        <div class="searchbg">
                            <form action="~/Content/HBThemes/list4.html">
                                <button type="submit" class="btn-search">Tìm kiếm</button>
                            </form>
                        </div>

                    </div>
                </div>
                <div class="col-md-4">
                    <div class="shadow cstyle05">
                        <div class="fwi one"><img src="~/Content/HBThemes/images/slide phong 1.jpg" alt="" /><div class="mhover none"><span class="icon"><a href="~/Content/HBThemes/list4.html"><img src="~/Content/HBThemes/images/spacer.png" alt="" /></a></span></div></div>
                        <div class="ctitle">
                            Phú Quốc<a href="~/Content/HBThemes/list4.html"><img src="~/Content/HBThemes/images/spacer.png" alt="" /></a>
                            <span>$59.99</span>
                        </div>
                    </div>
                </div>
                <div class="col-md-4">
                    <div class="shadow cstyle05">
                        <div class="fwi one"><img src="~/Content/HBThemes/images/slide phong 2.jpg" alt="" /><div class="mhover none"><span class="icon"><a href="~/Content/HBThemes/list4.html"><img src="~/Content/HBThemes/images/spacer.png" alt="" /></a></span></div></div>
                        <div class="ctitle">
                            Nha Trang<a href="~/Content/HBThemes/list4.html"><img src="~/Content/HBThemes/images/spacer.png" alt="" /></a>
                            <span>$59.99</span>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div class="deals3">
            <div class="container">
                <div class="row">
                    <div class="col-md-4">
                        <span class="dtitle">Nhanh tay đặt trước</span>
                        <div class="deal">
                            <a href="~/Content/HBThemes/details.html"><img src="~/Content/HBThemes/images/thumb-img-deawoo.jpg" alt="" class="dealthumb" /></a>
                            <div class="dealtitle">
                                <p><a href="~/Content/HBThemes/details.html" class="dark">Khách sạn Deawoo</a></p>
                                <img src="~/Content/HBThemes/images/smallrating-4.png" alt="" class="mt-10" /><span class="size13 grey mt-9">CuongHD</span>
                            </div>
                            <div class="dealprice">
                                <p class="size12 grey lh2">chỉ từ<span class="price">$35</span><br />mỗi đêm</p>
                            </div>
                        </div>
                        <div class="deal">
                            <a href="~/Content/HBThemes/details.html"><img src="~/Content/HBThemes/images/thumb-img-saigondalat.png" alt="" class="dealthumb" /></a>
                            <div class="dealtitle">
                                <p><a href="~/Content/HBThemes/details.html" class="dark">SaiGon-DaLat</a></p>
                                <img src="~/Content/HBThemes/images/smallrating-3.png" alt="" class="mt-10" /><span class="size13 grey mt-9">LyNH</span>
                            </div>
                            <div class="dealprice">
                                <p class="size12 grey lh2">chỉ từ<span class="price">$49</span><br />mỗi đêm</p>
                            </div>
                        </div>
                        <div class="deal">
                            <a href="~/Content/HBThemes/details.html"><img src="~/Content/HBThemes/images/thumb-img-hue.jpg" alt="" class="dealthumb" /></a>
                            <div class="dealtitle">
                                <p><a href="~/Content/HBThemes/details.html" class="dark">Hue Hotel</a></p>
                                <img src="~/Content/HBThemes/images/smallrating-4.png" alt="" class="mt-10" /><span class="size13 grey mt-9">DuanTH</span>
                            </div>
                            <div class="dealprice">
                                <p class="size12 grey lh2">chỉ từ<span class="price">$90</span><br />mỗi đêm</p>
                            </div>
                        </div>
                    </div>
                    <!-- End of first row-->

                    <div class="col-md-4">
                        <span class="dtitle">Khuyến mại</span>
                        <div class="deal">
                            <a href="~/Content/HBThemes/details.html"><img src="~/Content/HBThemes/images/thumb-img-cantho.png" alt="" class="dealthumb" /></a>
                            <div class="dealtitle">
                                <p><a href="~/Content/HBThemes/details.html" class="dark">Asia Hotel</a></p>
                                <img src="~/Content/HBThemes/images/smallrating-4.png" alt="" class="mt-10" /><span class="size13 grey mt-9">CuongHD</span>
                            </div>
                            <div class="dealprice">
                                <p class="size12 grey lh2">giảm từ<span class="price">10%</span><br />mỗi đêm</p>
                            </div>
                        </div>
                        <div class="deal">
                            <a href="~/Content/HBThemes/details.html"><img src="~/Content/HBThemes/images/thumb-img-saigon.jpg" alt="" class="dealthumb" /></a>
                            <div class="dealtitle">
                                <p><a href="~/Content/HBThemes/details.html" class="dark">Sài Gòn Hotel</a></p>
                                <img src="~/Content/HBThemes/images/smallrating-3.png" alt="" class="mt-10" /><span class="size13 grey mt-9">NhatNH</span>
                            </div>
                            <div class="dealprice">
                                <p class="size12 grey lh2">giảm từ<span class="price">15%</span><br />mỗi đêm</p>
                            </div>
                        </div>
                        <div class="deal">
                            <a href="~/Content/HBThemes/details.html"><img src="~/Content/HBThemes/images/thumb-img-catba.jpg" alt="" class="dealthumb" /></a>
                            <div class="dealtitle">
                                <p><a href="~/Content/HBThemes/details.html" class="dark">Cát Bà Hotel</a></p>
                                <img src="~/Content/HBThemes/images/smallrating-3.png" alt="" class="mt-10" /><span class="size13 grey mt-9">PhuongNT</span>
                            </div>
                            <div class="dealprice">
                                <p class="size12 grey lh2">giảm từ<span class="price">5%</span><br />mỗi đêm</p>
                            </div>
                        </div>
                    </div>
                    <!-- End of first row-->

                    <div class="col-md-4">
                        <span class="dtitle">Dịch vụ tốt nhất</span>
                        <div class="deal">
                            <a href="~/Content/HBThemes/details.html"><img src="~/Content/HBThemes/images/thumb-img-lecuoi.jpg" alt="" class="dealthumb" /></a>
                            <div class="dealtitle">
                                <p><a href="~/Content/HBThemes/details.html" class="dark">Tổ chức đám cưới</a></p>
                                <img src="~/Content/HBThemes/images/smallrating-4.png" alt="" class="mt-10" /><span class="size13 grey mt-9">CuongHD</span>
                            </div>
                            <div class="dealprice">
                                <p class="size12 grey lh2">chỉ từ<span class="price">$2000</span><br />trọn gói</p>
                            </div>
                        </div>
                        <div class="deal">
                            <a href="~/Content/HBThemes/details.html"><img src="~/Content/HBThemes/images/thumb-img-beboi.jpg" alt="" class="dealthumb" /></a>
                            <div class="dealtitle">
                                <p><a href="~/Content/HBThemes/details.html" class="dark">Bể bơi cặp đôi</a></p>
                                <img src="~/Content/HBThemes/images/smallrating-3.png" alt="" class="mt-10" /><span class="size13 grey mt-9">LyNH</span>
                            </div>
                            <div class="dealprice">
                                <p class="size12 grey lh2">chỉ từ<span class="price">$50</span><br />mỗi giờ</p>
                            </div>
                        </div>
                        <div class="deal">
                            <a href="~/Content/HBThemes/details.html"><img src="~/Content/HBThemes/images/thumb-img-massage.jpg" alt="" class="dealthumb" /></a>
                            <div class="dealtitle">
                                <p><a href="~/Content/HBThemes/details.html" class="dark">Massage</a></p>
                                <img src="~/Content/HBThemes/images/smallrating-3.png" alt="" class="mt-10" /><span class="size13 grey mt-9">NhatNH</span>
                            </div>
                            <div class="dealprice">
                                <p class="size12 grey lh2">chỉ từ<span class="price">$30</span><br />mỗi giờ</p>
                            </div>
                        </div>
                    </div>
                    <!-- End of first row-->
                </div>
            </div>
        </div>

        <div class="lastminute3">
            <div class="container">
                <img src="~/Content/HBThemes/images/rating-4.png" alt="" /><br />
                Đặt trước mới nhất: <b>Phú quốc</b> - 2 đêm - Bay + 4*Khách sạn, ngày 27/07 from $209/người<br />
                <form action="~/Content/HBThemes/details.html">
                    <button class="btn iosbtn" type="submit">Đọc thêm</button>
                </form>
            </div>
        </div>

        <div class="container cstyle06">

            <div class="row anim2">
                <div class="col-md-3">
                    <h2>Top<br />Lựa chọn hôm nay</h2><br />
                    Hãy bắt đầu tìm địa điểm thư giãn tốt nhất.
                </div>
                <div class="col-md-9">
                    <!-- Carousel -->
                    <div class="wrapper">
                        <div class="list_carousel">
                            <ul id="foo">
                                <li>
                                    <a href="~/Content/HBThemes/list4.html"><img src="~/Content/HBThemes/images/thumb-hoian.jpg" alt="" /></a>
                                    <div class="m1">
                                        <h6 class="lh1 dark"><b>Hội An</b></h6>
                                        <h6 class="lh1 green">Tiết kiệm đến 30%</h6>
                                    </div>
                                </li>
                                <li>
                                    <a href="~/Content/HBThemes/list4.html"><img src="~/Content/HBThemes/images/thumb-phuquoc.jpg" alt="" /></a>
                                    <div class="m1">
                                        <h6 class="lh1 dark"><b>Phú Quốc</b></h6>
                                        <h6 class="lh1 green">Tiết kiệm đến 25%</h6>
                                    </div>
                                </li>
                                <li>
                                    <a href="~/Content/HBThemes/list4.html"><img src="~/Content/HBThemes/images/thumb-danang.jpg" alt="" /></a>
                                    <div class="m1">
                                        <h6 class="lh1 dark"><b>Đà Nẵng</b></h6>
                                        <h6 class="lh1 green">Tiết kiệm đến 20%</h6>
                                    </div>
                                </li>
                                <li>
                                    <a href="~/Content/HBThemes/list4.html"><img src="~/Content/HBThemes/images/thumb-sapa.jpg" alt="" /></a>
                                    <div class="m1">
                                        <h6 class="lh1 dark"><b>Sapa</b></h6>
                                        <h6 class="lh1 green">Tiết kiệm đến 30%</h6>
                                    </div>
                                </li>
                                <li>
                                    <a href="~/Content/HBThemes/list4.html"><img src="~/Content/HBThemes/images/thumb-quangninh.jpg" alt="" /></a>
                                    <div class="m1">
                                        <h6 class="lh1 dark"><b>Quảng Ninh</b></h6>
                                        <h6 class="lh1 green">Tiết kiệm đến 15%</h6>
                                    </div>
                                </li>
                                <li>
                                    <a href="~/Content/HBThemes/list4.html"><img src="~/Content/HBThemes/images/thumb-cantho.jpg" alt="" /></a>
                                    <div class="m1">
                                        <h6 class="lh1 dark"><b>Cần Thơ</b></h6>
                                        <h6 class="lh1 green">Tiết kiệm đến 15%</h6>
                                    </div>
                                </li>
                            </ul>
                            <div class="clearfix"></div>
                            <a id="prev_btn" class="prev" href="#"><img src="~/Content/HBThemes/images/spacer.png" alt="" /></a>
                            <a id="next_btn" class="next" href="#"><img src="~/Content/HBThemes/images/spacer.png" alt="" /></a>
                        </div>
                    </div>
                </div>
            </div>

            <hr class="featurette-divider2">

            <div class="row anim3">
                <div class="col-md-3">
                    <h2>Best<br />Các dịch vụ</h2><br />
                    Những dịch vụ tốt nhất tại các khách sạn.
                </div>
                <div class="col-md-9">

                    <!-- Carousel -->
                    <div class="wrapper">
                        <div class="list_carousel">
                            <ul id="foo2">
                                <li>
                                    <a href="~/Content/HBThemes/list3.html"><img src="~/Content/HBThemes/images/thumb-dich vu 1.jpg" alt="" /></a>
                                    <div class="m1">
                                        <h6 class="lh1 dark"><b>Xông hơi</b></h6>
                                        <h6 class="lh1 green">Tiết kiệm đến 30%</h6>
                                    </div>
                                </li>
                                <li>
                                    <a href="~/Content/HBThemes/list3.html"><img src="~/Content/HBThemes/images/thumb-dich vu 2.jpg" alt="" /></a>
                                    <div class="m1">
                                        <h6 class="lh1 dark"><b>Massage</b></h6>
                                        <h6 class="lh1 green">Tiết kiệm đến 10%</h6>
                                    </div>
                                </li>
                                <li>
                                    <a href="~/Content/HBThemes/list3.html"><img src="~/Content/HBThemes/images/thumb-dich vu 3.jpg" alt="" /></a>
                                    <div class="m1">
                                        <h6 class="lh1 dark"><b>Chăm sóc thú cưng</b></h6>
                                        <h6 class="lh1 green">Tiết kiệm đến 20%</h6>
                                    </div>
                                </li>
                                <li>
                                    <a href="~/Content/HBThemes/list3.html"><img src="~/Content/HBThemes/images/thumb-dich vu 4.jpg" alt="" /></a>
                                    <div class="m1">
                                        <h6 class="lh1 dark"><b>Bể bơi</b></h6>
                                        <h6 class="lh1 green">Tiết kiệm đến 15%</h6>
                                    </div>
                                </li>
                                <li>
                                    <a href="~/Content/HBThemes/list3.html"><img src="~/Content/HBThemes/images/thumb-dich vu 5.jpg" alt="" /></a>
                                    <div class="m1">
                                        <h6 class="lh1 dark"><b>Sân golf</b></h6>
                                        <h6 class="lh1 green">Tiết kiệm đến 25%</h6>
                                    </div>
                                </li>
                                <li>
                                    <a href="~/Content/HBThemes/list3.html"><img src="~/Content/HBThemes/images/thumb-dich vu 6.jpg" alt="" /></a>
                                    <div class="m1">
                                        <h6 class="lh1 dark"><b>Rượu ngoại</b></h6>
                                        <h6 class="lh1 green">Tiết kiệm đến 30%</h6>
                                    </div>
                                </li>
                            </ul>
                            <div class="clearfix"></div>
                            <a id="prev_btn2" class="prev" href="#"><img src="~/Content/HBThemes/images/spacer.png" alt="" /></a>
                            <a id="next_btn2" class="next" href="#"><img src="~/Content/HBThemes/images/spacer.png" alt="" /></a>
                        </div>
                    </div>

                </div>
            </div>

        </div>
    </div>

</body>
</html>

@*<h2>Home</h2>*@

