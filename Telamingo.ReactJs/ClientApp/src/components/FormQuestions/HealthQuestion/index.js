import React, {useState} from "react";
import style from "./healthQuestion.module.css";
import MentalHealth from "../MentalHealth";

const HealthQuestion = (props) => {

    const [firstQuestion, setFirstQuestion] = useState(false);
    const [secondQuestion, setSecondQuestion] = useState(false);
    const [thirdQuestion, setThirdQuestion] = useState(false);
    const [forthQuestion, setForthQuestion] = useState(false);
    const [haveASick, setHaveASick] = useState(false);
    const [sick, setSick] = useState("");
    const [firstMealRate, setFirstMealRate] = useState("");
    const [secondMealRate, setSecondMealRate] = useState("");
    const [thirdMealRate, setThirdMealRate] = useState("");
    const [forthMealRate, setForthMealRate] = useState("");
    const [fifthMealRate, setFifthMealRate] = useState("");

    const sicks = [
        "sick a", "sick b", "sick c"
    ]
    return (
        <React.Fragment>
            {
                !forthQuestion ? (
                    <div className={` col-lg-12 ${style.questionBody}`}>
                        {/*<div className={`${style.questionHeader} mt-3`}>*/}
                        {/*    <h3>*/}
                        {/*        سلامت جسمانی (۴ سوال)*/}
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
                                        <div>
                                            <p className={`${style.questionTitle}`}>
                                                معمولا نیاز شما به پزشک چقدر است؟
                                            </p>
                                        </div>
                                        <div className={` ${style.chooseSickRate} mt-3`}>
                                            <div>
                                                <button onClick={() => setFirstQuestion(true)}>خیلی به ندرت به پزشک
                                                    مراجعه میکنم و اعتقادی به پزشک ندارم مگر مجبور شوم (5)
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setFirstQuestion(true)}>به پزشک اعتقاد دارم اما
                                                    به ندرت نیاز به پزشک پیدا میکنم (4)
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setFirstQuestion(true)}>برای چکاپ دوره‌ای به پزشک
                                                    مراجعه می‌کنم (3)
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setFirstQuestion(true)}>به دلیل بیماری یک بیماری،
                                                    باید به طور مرتب به پزشک مراجعه کنم (2)
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setFirstQuestion(true)}>معمولا به صورت اورژانسی
                                                    به پزشک نیاز پیدا میکنم (1)
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setFirstQuestion(true)}>به پزشک مراجعه میکنم اما
                                                    فقط به پزشکان طب سنتی (طب اسلامی) اعتقاد دارم (0)
                                                </button>
                                            </div>
                                        </div>
                                    </React.Fragment>
                                ) : !secondQuestion ? (
                                    <React.Fragment>
                                        {
                                            !haveASick ? (
                                                <React.Fragment>
                                                    <div>
                                                        <p className={`${style.questionTitle}`}>
                                                            آیا دارای بیماری خاصی هستید؟
                                                        </p>
                                                    </div>
                                                    <div className={` ${!props.isMobile ? style.chooseHaveSick : style.chooseHaveSickM} mt-3 ${!props.isMobile ? " ":`row`}`}>
                                                        <div>
                                                            <button onClick={() => setSecondQuestion(true)}>خیر</button>
                                                        </div>
                                                        <div>
                                                            <button onClick={() => setHaveASick(true)}>بله</button>
                                                        </div>
                                                    </div>
                                                    <div className={`${!props.isMobile ? style.mobileButton : style.mobileButtonM}`}>
                                                        <button className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                                onClick={() => setFirstQuestion(false)}>سوال قبلی
                                                        </button>
                                                    </div>
                                                </React.Fragment>
                                            ) : (
                                                <React.Fragment>
                                                    <div className={`${style.chooseSick} mt-5 mb-5`}>
                                                        بیماری شما:
                                                        <select value={sick}
                                                                onChange={(event) => setSick(event.target.value)} required>
                                                            <option value="انتخاب کشوراول" selected>انتخاب بیماری
                                                            </option>
                                                            {
                                                                sicks.map(item => <option value={item}>{item}</option>)
                                                            }
                                                        </select>
                                                    </div>
                                                    {
                                                        sick == "" ?
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
                                            )
                                        }
                                    </React.Fragment>
                                ) : !thirdQuestion ? (
                                    <React.Fragment>
                                        <div>
                                            <p className={`${style.questionTitle}`}>
                                                انتظار دارید بعد از مهاجرت چند درصد از درآمد سالیانه شما صرف هزینه های
                                                درمانی شود؟
                                            </p>
                                        </div>
                                        <div className={` ${!props.isMobile ? style.chooseHaveSick : style.chooseHaveSickM} mt-3 ${!props.isMobile ? " ":`row`}`}>
                                            <div>
                                                <button onClick={() => setThirdQuestion(true)}>بالای 80 درصد</button>
                                            </div>
                                            <div>
                                                <button onClick={() => setThirdQuestion(true)}>60 تا 80 درصد
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setThirdQuestion(true)}>حدود 50 درصد
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setThirdQuestion(true)}>بین 20 تا 40 درصد
                                                </button>
                                            </div>
                                            <div>
                                                <button onClick={() => setThirdQuestion(true)}>کمتر از 10 درصد
                                                </button>
                                            </div>
                                        </div>
                                        <div className={`${!props.isMobile ? style.mobileButton : style.mobileButtonM}`}>
                                            <button className={`mt-5 mb-3 ${style.nextQuestionButtonActive}`}
                                                    onClick={() => setSecondQuestion(false)}>سوال قبلی
                                            </button>
                                        </div>
                                    </React.Fragment>
                                ) : !forthQuestion ? (
                                    <React.Fragment>
                                        <div>
                                            <p className={`${style.questionTitle}`}>
                                                سازگاری شما (یا خانواده شما) با هر لایف استایل غذایی چقدر است؟
                                            </p>
                                        </div>
                                        <div className={`mt-3 ${style.mealHoby}`}>
                                            <label>غذاهای سنتی کشور خودم (1 تا 10)</label>
                                            <input type="number" min="1" max="10" step="1"
                                                   onChange={(event) => setFirstMealRate(event.target.value)}/>
                                        </div>
                                        <div className={`mt-3 ${style.mealHoby}`}>
                                            <label>غذاهای فست فودی (1 تا 10)</label>
                                            <input type="number" min="1" max="10" step="1"
                                                   onChange={(event) => setSecondMealRate(event.target.value)}/>
                                        </div>
                                        <div className={`mt-3 ${style.mealHoby}`}>
                                            <label>گیاهخواری (1 تا 10)</label>
                                            <input type="number" min="1" max="10" step="1"
                                                   onChange={(event) => setThirdMealRate(event.target.value)}/>
                                        </div>
                                        <div className={`mt-3 ${style.mealHoby}`}>
                                            <label>غذای سنتی ملل (1 تا 10)</label>
                                            <input type="number" min="1" max="10" step="1"
                                                   onChange={(event) => setForthMealRate(event.target.value)}/>
                                        </div>
                                        <div className={`mt-3 ${style.mealHoby}`}>
                                            <label>لایف استایل غذایی خاصی را دنبال نمیکنم و معمولا همه جور غذایی میخورم
                                                (برایم فرقی نمیکند)غذاهای سنتی کشور خودم (1 تا 10)</label>
                                            <input type="number" min="1" max="10" step="1"
                                                   onChange={(event) => setFifthMealRate(event.target.value)}/>
                                        </div>
                                        {
                                            firstMealRate == "" ?
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
                                ) : null
                            }
                        </div>
                    </div>
                ) : <MentalHealth isMobile={props.isMobile}/>
            }
        </React.Fragment>
    )
}
export default HealthQuestion;