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
                        <div className={`${style.questionContent} mt-5`} dir='ltr'>
                            {
                                !firstQuestion ? (
                                    <React.Fragment>
                                        <div className={`mb-3 ${style.question}`}>
                                            <p className={`mt-3`}>
                                                How important are religious issues to you and do you adhere to them?
                                            </p>
                                            {/*<p className={`${style.questionDsc}`}>*/}
                                            {/*    اعتقادات و ارزش های مذهبی بسیار برایم اهمیت دارد (به طور مثال برایم مهم است که بتوانم در مراسم های مذهبی همچون عزاداری ها، جشن ها و .... به صورت جمعی شرکت کنم) (10)*/}
                                            {/*</p>*/}
                                            {/*<p className={`${style.questionDsc}`}>*/}
                                            {/*    اعتقادات مذهبی ندارم و برایم اعتقادات دیگران نیز اهمیتی ندارد (0)*/}
                                            {/*</p>*/}
                                        </div>
                                        <div className={` ${!props.isMobile ? style.creedRate : style.creedRateM} mt-5`}>
                                            <div>
                                                <button onClick={() => setFirstQuestion(true)}>0</button>
                                            </div>
                                            <div>
                                                <button onClick={() => setFirstQuestion(true)}>1</button>
                                            </div>
                                            <div>
                                                <button onClick={() => setFirstQuestion(true)}>2
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setFirstQuestion(true)}>3
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setFirstQuestion(true)}>4
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setFirstQuestion(true)}>5</button>
                                            </div>
                                            <div>
                                                <button onClick={() => setFirstQuestion(true)}>6</button>
                                            </div>
                                            <div>
                                                <button onClick={() => setFirstQuestion(true)}>7
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setFirstQuestion(true)}>8
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setFirstQuestion(true)}>9
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setFirstQuestion(true)}>10</button>
                                            </div>
                                        </div>
                                        <div className={`mb-5 ${style.creedRateDsc}`}>
                                            <span>I do not have religious beliefs and it does not matter to me</span>
                                            <span>Religious beliefs and values are very important to me</span>
                                        </div>
                                        {/*<div className={`${style.creedRate} mt-5 mb-5`}>*/}
                                        {/*    <span>0</span>*/}
                                        {/*    <input type="range" min="0" max="10" onChange={(event)=>setFirstQuestionRate(event.target.value)}/>*/}
                                        {/*    <span>{firstQuestionRate}</span>*/}
                                        {/*</div>*/}
                                        {/*{*/}
                                        {/*    firstQuestionRate == "عدد مدنظر خود را مشخص کنید" ?*/}
                                        {/*        <div className={`${!props.isMobile ? "" : style.mobileButtonM}`}>*/}
                                        {/*            <button*/}
                                        {/*                className={`mt-5 mb-3 ${style.nextQuestionButtonDeActive}`}>سوال*/}
                                        {/*                بعدی*/}
                                        {/*            </button>*/}
                                        {/*        </div>*/}
                                        {/*        :*/}
                                        {/*        <div className={`${!props.isMobile ? "" : style.mobileButtonM}`}>*/}
                                        {/*            <button*/}
                                        {/*                className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}*/}
                                        {/*                onClick={() => setFirstQuestion(true)}>سوال*/}
                                        {/*                بعدی*/}
                                        {/*            </button>*/}
                                        {/*        </div>*/}
                                        {/*}*/}
                                    </React.Fragment>
                                ) : !secondQuestion ? (
                                    <React.Fragment>
                                        <div className={`mb-3 ${style.question}`}>
                                            <p className={`mt-3`}>
                                                Are national issues such as serving your compatriots, the future of the country, etc. important to you and may prevent you from migrating?
                                            </p>
                                            {/*<p className={`${style.questionDsc}`}>*/}
                                            {/*    اعتقادات و ارزش های مذهبی بسیار برایم اهمیت دارد (به طور مثال برایم مهم است که بتوانم در مراسم های مذهبی همچون عزاداری ها، جشن ها و .... به صورت جمعی شرکت کنم) (10)*/}
                                            {/*</p>*/}
                                            {/*<p className={`${style.questionDsc}`}>*/}
                                            {/*    اعتقادات مذهبی ندارم و برایم اعتقادات دیگران نیز اهمیتی ندارد (0)*/}
                                            {/*</p>*/}
                                        </div>
                                        <div className={` ${!props.isMobile ? style.creedRate : style.creedRateM} mt-5`}>
                                            <div>
                                                <button onClick={() => setSecondQuestion(true)}>0</button>
                                            </div>
                                            <div>
                                                <button onClick={() => setSecondQuestion(true)}>1</button>
                                            </div>
                                            <div>
                                                <button onClick={() => setSecondQuestion(true)}>2
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setSecondQuestion(true)}>3
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setSecondQuestion(true)}>4
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setSecondQuestion(true)}>5</button>
                                            </div>
                                            <div>
                                                <button onClick={() => setSecondQuestion(true)}>6</button>
                                            </div>
                                            <div>
                                                <button onClick={() => setSecondQuestion(true)}>7
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setSecondQuestion(true)}>8
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setSecondQuestion(true)}>9
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setSecondQuestion(true)}>10</button>
                                            </div>
                                        </div>
                                        <div className={`mb-5 ${style.creedRateDsc}`}>
                                            <span>I almost do not care</span>
                                            <span>I almost do not care National issues are very important to me</span>
                                        </div>
                                    </React.Fragment>
                                ): !thirdQuestion ? (
                                    <React.Fragment>
                                        <div className={`mb-3 ${style.question}`}>
                                            <p className={`mt-3`}>
                                                How important is the size of the immigrant community of the destination country and the existence of communities related to your country or nationality?
                                            </p>
                                            {/*<p className={`${style.questionDsc}`}>*/}
                                            {/*    اعتقادات و ارزش های مذهبی بسیار برایم اهمیت دارد (به طور مثال برایم مهم است که بتوانم در مراسم های مذهبی همچون عزاداری ها، جشن ها و .... به صورت جمعی شرکت کنم) (10)*/}
                                            {/*</p>*/}
                                            {/*<p className={`${style.questionDsc}`}>*/}
                                            {/*    اعتقادات مذهبی ندارم و برایم اعتقادات دیگران نیز اهمیتی ندارد (0)*/}
                                            {/*</p>*/}
                                        </div>
                                        <div className={` ${!props.isMobile ? style.creedRate : style.creedRateM} mt-5`}>
                                            <div>
                                                <button onClick={() => setThirdQuestion(true)}>0</button>
                                            </div>
                                            <div>
                                                <button onClick={() => setThirdQuestion(true)}>1</button>
                                            </div>
                                            <div>
                                                <button onClick={() => setThirdQuestion(true)}>2
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setThirdQuestion(true)}>3
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setThirdQuestion(true)}>4
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setThirdQuestion(true)}>5</button>
                                            </div>
                                            <div>
                                                <button onClick={() => setThirdQuestion(true)}>6</button>
                                            </div>
                                            <div>
                                                <button onClick={() => setThirdQuestion(true)}>7
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setThirdQuestion(true)}>8
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setThirdQuestion(true)}>9
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setThirdQuestion(true)}>10</button>
                                            </div>
                                        </div>
                                        <div className={`mb-5 ${style.creedRateDsc}`}>
                                            <span>I would like to be away from my compatriots</span>
                                            <span>I would like the country I want to immigrate to to be fully immigrant</span>
                                        </div>
                                    </React.Fragment>
                                ) : !forthQuestion ? (
                                    <React.Fragment>
                                        <div className={`mb-3 ${style.question}`}>
                                            <p className={`mt-3`}>
                                                How important is the similarity of the community context, social relations and other socio-cultural parameters of the destination country with your community?
                                            </p>
                                            {/*<p className={`${style.questionDsc}`}>*/}
                                            {/*    اعتقادات و ارزش های مذهبی بسیار برایم اهمیت دارد (به طور مثال برایم مهم است که بتوانم در مراسم های مذهبی همچون عزاداری ها، جشن ها و .... به صورت جمعی شرکت کنم) (10)*/}
                                            {/*</p>*/}
                                            {/*<p className={`${style.questionDsc}`}>*/}
                                            {/*    اعتقادات مذهبی ندارم و برایم اعتقادات دیگران نیز اهمیتی ندارد (0)*/}
                                            {/*</p>*/}
                                        </div>
                                        <div className={` ${!props.isMobile ? style.creedRate : style.creedRateM} mt-5`}>
                                            <div>
                                                <button onClick={() => setForthQuestion(true)}>0</button>
                                            </div>
                                            <div>
                                                <button onClick={() => setForthQuestion(true)}>1</button>
                                            </div>
                                            <div>
                                                <button onClick={() => setForthQuestion(true)}>2
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setForthQuestion(true)}>3
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setForthQuestion(true)}>4
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setForthQuestion(true)}>5</button>
                                            </div>
                                            <div>
                                                <button onClick={() => setForthQuestion(true)}>6</button>
                                            </div>
                                            <div>
                                                <button onClick={() => setForthQuestion(true)}>7
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setForthQuestion(true)}>8
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setForthQuestion(true)}>9
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setForthQuestion(true)}>10</button>
                                            </div>
                                        </div>
                                        <div className={`mb-5 ${style.creedRateDsc}`}>
                                            <span>I would like to experience a different society in terms of social relations and cultural context</span>
                                            <span>I want it to be very similar</span>
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