import React, {useState} from "react";
import style from "./cultureQuestion.module.css";
import HealthQuestion from "../HealthQuestion";

const CultureQuestions = (props) =>{

    const [firstQuestion, setFirstQuestion] = useState(false);
    const [secondQuestion, setSecondQuestion] = useState(false);
    const [thirdQuestion, setThirdQuestion] = useState(false);
    const [forthQuestion, setForthQuestion] = useState(false);
    const [firstQuestionRate, setFirstQuestionRate]=useState("عدد مدنظر خود را مشخص کنید");
    const [secondQuestionRate, setSecondQuestionRate]=useState("عدد مدنظر خود را مشخص کنید");
    const [ThirdQuestionRate, setThirdQuestionRate]=useState("عدد مدنظر خود را مشخص کنید");
    const [ForthQuestionRate, setForthQuestionRate]=useState("عدد مدنظر خود را مشخص کنید");

    return(
        <React.Fragment>
            {
                !forthQuestion ?
                    <div className={` col-lg-12 ${style.questionBody}`}>
                        {/*<div className={`${style.questionHeader} mt-3`}>*/}
                        {/*    <h3>*/}
                        {/*        فرهنگی (۴ سوال)*/}
                        {/*    </h3>*/}
                        {/*    <i className={`${firstQuestion ? style.active : style.deActive}`}> </i>*/}
                        {/*    <i className={`${secondQuestion ? style.active : style.deActive}`}> </i>*/}
                        {/*    <i className={`${thirdQuestion ? style.active : style.deActive}`}> </i>*/}
                        {/*    <i className={`${forthQuestion ? style.active : style.deActive}`}> </i>*/}
                        {/*</div>*/}
                        <div className={`${style.questionContent} mt-5`} dir='rtl'>
                            {
                                !firstQuestion ? (
                                    <React.Fragment>
                                        <div className={`mb-3`}>
                                            <p className={`mt-3 ${style.questionTitle}`}>
                                                چقدر مسائل دینی-ارزشی برای شما مهم است و به آن پایبندید؟
                                            </p>
                                            <p className={`${style.questionDsc}`}>
                                                اعتقادات و ارزش های مذهبی بسیار برایم اهمیت دارد (به طور مثال برایم مهم است که بتوانم در مراسم های مذهبی همچون عزاداری ها، جشن ها و .... به صورت جمعی شرکت کنم) (10)
                                            </p>
                                            <p className={`${style.questionDsc}`}>
                                                اعتقادات مذهبی ندارم و برایم اعتقادات دیگران نیز اهمیتی ندارد (0)
                                            </p>
                                        </div>
                                        <div className={`${style.creedRate} mt-5 mb-5`}>
                                            <span>0</span>
                                            <input type="range" min="0" max="10" onChange={(event)=>setFirstQuestionRate(event.target.value)}/>
                                            <span>{firstQuestionRate}</span>
                                        </div>
                                        {
                                            firstQuestionRate == "عدد مدنظر خود را مشخص کنید" ?
                                                <div className={`${!props.isMobile ? "" : style.mobileButtonM}`}>
                                                    <button
                                                        className={`mt-5 mb-3 ${style.nextQuestionButtonDeActive}`}>سوال
                                                        بعدی
                                                    </button>
                                                </div>
                                                :
                                                <div className={`${!props.isMobile ? "" : style.mobileButtonM}`}>
                                                    <button
                                                        className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                        onClick={() => setFirstQuestion(true)}>سوال
                                                        بعدی
                                                    </button>
                                                </div>
                                        }
                                    </React.Fragment>
                                ) : !secondQuestion ? (
                                    <React.Fragment>
                                        <div className={`mb-3`}>
                                            <p className={`mt-3 ${style.questionTitle}`}>
                                                چقدر مسائل ملی برای شما مهم است و به آینده کشور خود اهمیت میدهید؟
                                            </p>
                                            <p className={`${style.questionDsc}`}>
                                                مسائل ملی بسیار برایم اهمیت دارد (به طور مثال برایم مهم است که بتوانم در رویدادهای ملی همچون جشن ها، انتخابات و .... شرکت کنم) (10)
                                            </p>
                                            <p className={`${style.questionDsc}`}>
                                                اعتقادات وطن پرستانه ندارم و این موضوع دغدغه من نیست (0)
                                            </p>
                                        </div>
                                        <div className={`${style.creedRate} mt-5 mb-5`}>
                                            <span>0</span>
                                            <input type="range" name="vol" min="0" max="10" onChange={(event)=>setSecondQuestionRate(event.target.value)}/>
                                            <span>{secondQuestionRate}</span>
                                        </div>
                                        {
                                            secondQuestionRate == "" ?
                                                <div className={`${!props.isMobile ? "" : style.mobileButtonM}`}>
                                                    <button
                                                        className={`mt-5 mb-3 ${style.nextQuestionButtonDeActive}`}>سوال
                                                        بعدی
                                                    </button>
                                                </div>
                                                :
                                                <div className={`${!props.isMobile ? "" : style.mobileButtonM}`}>
                                                    <button
                                                        className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                        onClick={() => setSecondQuestion(true)}>سوال
                                                        بعدی
                                                    </button>
                                                </div>
                                        }
                                        <div className={`${!props.isMobile ? style.mobileButton : style.mobileButtonM}`}>
                                            <button className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                    onClick={() => setFirstQuestion(false)}>سوال قبلی
                                            </button>
                                        </div>
                                    </React.Fragment>
                                ): !thirdQuestion ? (
                                    <React.Fragment>
                                        <div className={`mb-3`}>
                                            <p className={`mt-3 ${style.questionTitle}`}>
                                                چقدر اندازه جامعه مهاجرین کشور مقصد و وجود کامیونیتی های مربوط به کشور یا ملیت شما برای شما اهمیت دارد؟
                                            </p>
                                            <p className={`${style.questionDsc}`}>
                                                دوست دارم کشوری که میخواهم به آن مهاجرت کنم کاملا مهاجر پذیر باشد و کامیونیتی هایی از هموطنانم در آن وجود داشته باشد (10)
                                            </p>
                                            <p className={`${style.questionDsc}`}>
                                                این موضوع به هیچ وجه برایم اهمیتی ندارد و به آن اصلا فکر نمیکنم (5)
                                            </p>
                                            <p className={`${style.questionDsc}`}>
                                                دوست دارم تا از هموطنانم دور باشم و کشور مقصد نیز کاملا یکدست و با مهاجران بسیاری کمی باشد (0)
                                            </p>
                                        </div>
                                        <div className={`${style.creedRate} mt-5 mb-5`}>
                                            <span>0</span>
                                            <input type="range" name="vol" min="0" max="10" onChange={(event)=>setThirdQuestionRate(event.target.value)}/>
                                            <span>{ThirdQuestionRate}</span>
                                        </div>
                                        {
                                            ThirdQuestionRate == "" ?
                                                <div className={`${!props.isMobile ? "" : style.mobileButtonM}`}>
                                                    <button
                                                        className={`mt-5 mb-3 ${style.nextQuestionButtonDeActive}`}>سوال
                                                        بعدی
                                                    </button>
                                                </div>
                                                :
                                                <div className={`${!props.isMobile ? "" : style.mobileButtonM}`}>
                                                    <button
                                                        className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                        onClick={() => setThirdQuestion(true)}>سوال
                                                        بعدی
                                                    </button>
                                                </div>
                                        }
                                        <div className={`${!props.isMobile ? style.mobileButton : style.mobileButtonM}`}>
                                            <button className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                    onClick={() => setSecondQuestion(false)}>سوال قبلی
                                            </button>
                                        </div>
                                    </React.Fragment>
                                ) : !forthQuestion ? (
                                    <React.Fragment>
                                        <div className={`mb-3`}>
                                            <p className={`mt-3 ${style.questionTitle}`}>
                                                چقدر شباهت بافت جامعه، روابط اجتماعی و سایر پارامترهای فرهنگی-اجتماعی کشور مقصد با جامعه شما، برای شما اهمیت دارد؟
                                            </p>
                                            <p className={`${style.questionDsc}`}>
                                                تمایل دارم بسیار شبیه باشد (10)
                                            </p>
                                            <p className={`${style.questionDsc}`}>
                                                برایم فرقی نمیکند (5)
                                            </p>
                                            <p className={`${style.questionDsc}`}>
                                                دوست دارم از نظر روابط اجتماعی و بافت فرهنگی، جامعه متفاتی را تجربه کنم (0)
                                            </p>
                                        </div>
                                        <div className={`${style.creedRate} mt-5 mb-5`}>
                                            <span>0</span>
                                            <input type="range" name="vol" min="0" max="10" onChange={(event)=>setForthQuestionRate(event.target.value)}/>
                                            <span>{ForthQuestionRate}</span>
                                        </div>
                                        {
                                            ForthQuestionRate == "" ?
                                                <div className={`${!props.isMobile ? "" : style.mobileButtonM}`}>
                                                    <button
                                                        className={`mt-5 mb-3 ${style.nextQuestionButtonDeActive}`}>سوال
                                                        بعدی
                                                    </button>
                                                </div>
                                                :
                                                <div className={`${!props.isMobile ? "" : style.mobileButtonM}`}>
                                                    <button
                                                        className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                        onClick={() => setForthQuestion(true)}>سوال
                                                        بعدی
                                                    </button>
                                                </div>
                                        }
                                        <div className={`${!props.isMobile ? style.mobileButton : style.mobileButtonM}`}>
                                            <button className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                    onClick={() => setThirdQuestion(false)}>سوال قبلی
                                            </button>
                                        </div>
                                    </React.Fragment>
                                ): null
                            }
                        </div>
                    </div>
                    :
                    <HealthQuestion isMobile={props.isMobile}/>
            }

        </React.Fragment>
    )
}
export default CultureQuestions;