const seats = document.querySelectorAll('.seat, .businessSeat');
const selectedSeatsList = document.getElementById('selected-seats-list');
let selectedSeat = null; // keep track of the currently selected seat

seats.forEach((seat) => {
  seat.addEventListener('click', () => {
    if (selectedSeat) {
      selectedSeat.classList.remove('selected');
    }
    seat.classList.add('selected');
    selectedSeat = seat;
    updateSelectedSeatsList();
  });
});

function updateSelectedSeatsList() {
  selectedSeatsList.innerHTML = ''; // clear the list
  if (selectedSeat) {
    const li = document.createElement('li');
    li.textContent = selectedSeat.dataset.seat;
    selectedSeatsList.appendChild(li);
  }
}

$(document).ready(function () {
    $('#book-button').click(function () {
        if (selectedSeat === null) {
            $('#error-message').show();
            return;
        }
        else {
            $('#error-message').hide();
        }
            
        var seatId = selectedSeat.dataset.seat;
        var userId = ''; // will be set after user creation

        var formData = $('form').serializeArray();
        var formDataObject = {};
        $.each(formData, function () {
            formDataObject[this.name] = this.value;
        });

        var flightId = $('input[name="FlightId"]').val();

        $.ajax({
            type: 'POST',
            url: addUserUrl,
            data: {
                user: formDataObject,
                flightId: flightId
            },
            success: function (data) {
                if (data.error) {
                    $('#error-message').text(data.error);
                    $('#error-message').show();
                } else {
                    $('#error-message').hide();
                    userId = data.userId; // возвращается значение с контроллера User метода Add
                    bookSeat(seatId, flightId, userId, 'Pending');
                }
            }
        });
    });

    $('#buy-button').click(function () {
        if (selectedSeat === null) {
            $('#error-message').show();
            return;
        }
        else {
            $('#error-message').hide();
        }
        
        var seatId = selectedSeat.dataset.seat;
        var userId = ''; // will be set after user creation

        var formData = $('form').serializeArray();
        var formDataObject = {};
        $.each(formData, function () {
            formDataObject[this.name] = this.value;
        });

        var flightId = $('input[name="FlightId"]').val();

        $.ajax({
            type: 'POST',
            url: addUserUrl,
            data: {
                user: formDataObject,
                flightId: flightId
            },
            success: function (data) {
                if (data.error) {
                    $('#error-message').text(data.error);
                    $('#error-message').show();
                } else {
                    $('#error-message').hide();
                    userId = data.userId; // возвращается значение с контроллера User метода Add
                    bookSeat(seatId, flightId, userId, 'Paid');
                }
            }
        });
    });
});

function bookSeat(seatId, flightId, userId, status) {
    $.ajax({
        type: 'POST',
        url: changeStatusUrl,
        data: {
            seatId: seatId
        },
        success: function () {
            addBooking(userId, flightId, status, seatId);
        }
    });
}

function addBooking(userId, flightId, status, seatId) {
    $.ajax({
        type: 'POST',
        url: addBookingUrl,
        data: {
            userId: userId,
            flightId: flightId,
            status: status,
            seatId: seatId
        },
        success: function (data) {
            var bookingId = data.bookingId; // assuming the Add method returns the created booking's Id
            var totalPrice = data.totalPrice;
            var redirectUrl = data.redirectURL;
            if (status === 'Paid') {
                makePayment(userId, bookingId, totalPrice, redirectUrl);
            }
            else {
                window.location.href = redirectUrl;
            }
        }
    });
}

function makePayment(userId, bookingId, totalPrice, redirectUrl) {
    $.ajax({
        type: 'POST',
        url: addPaymentUrl,
        data: {
            bookingId: bookingId,
            totalPrice: totalPrice
        },
        success: function () {
            window.location.href = redirectUrl;
        }
    });
}

